using GalaSoft.MvvmLight.Command;
using SporTucMobile.Interfaces;
using SporTucMobile.Models;
using SporTucMobile.Services;
using SporTucMobile.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        #region Attributes
        private Person _person { get; set; }
        public Person Person
        {
            get
            {
                return this._person;
            }
            set
            {
                if(value != _person)
                {
                    _person = value;
                    OnPropertyChanged();
                }
            }
        }

        private User _user { get; set; }
        public User User
        {
            get
            {
                return this._user;
            }
            set
            {
                if (value != _user)
                {
                    _user = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _confirmPassword { get; set; }
        public string ConfirmPassword
        {
            get
            {
                return this._confirmPassword;
            }
            set
            {
                if (value != _confirmPassword)
                {
                    _confirmPassword = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool _loadingIsRunning { get; set; }
        public bool LoadingIsRunning
        {
            get
            {
                return this._loadingIsRunning;
            }
            set
            {
                if (value != _loadingIsRunning)
                {
                    _loadingIsRunning = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool _loadingIsVisible { get; set; }
        public bool LoadingIsVisible
        {
            get
            {
                return this._loadingIsVisible;
            }
            set
            {
                if (value != _loadingIsVisible)
                {
                    _loadingIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandRegister { get { return new RelayCommand(Register); } }

        public ICommand CommandToReturn { get { return new RelayCommand(ToReturn); } }

        private readonly IMessage _message;
        #endregion

        #region Builders
        public RegisterViewModel()
        {
            _message = DependencyService.Get<IMessage>();
            InitialData();
        }
        #endregion

        #region Commands
        async void Register()
        {
            _loadingIsVisible = true;
            _loadingIsRunning = true;
            try
            {
                CheckData();
                CheckUserName();
                CheckEmail();
                var nowPerson = new Person
                {
                    Name = _person.Name,
                    LastName = _person.LastName,
                    Email = _person.Email,
                    NumMobile = _person.NumMobile
                };

                await App.SqlConnection.InsertAsync(nowPerson);

                var nowUser = new User
                {
                    UserName = _user.UserName,
                    Password = _user.Password,
                    Locked = false,
                    Person = nowPerson
                };

                await App.SqlConnection.InsertAsync(nowUser);

                _loadingIsVisible = false;
                _loadingIsRunning = false;
            }
            catch (Exception ex)
            {
                _loadingIsVisible = false;
                _loadingIsRunning = false;
                await this._message.MessageShowAsync("Mensaje", ex.Message);
            }
        }

        async void ToReturn()
        {
            if(await _message.QuestionShowAsync("Salir", "Seguro desea salir?"))
            {
                Application.Current.MainPage = new LoginPage();
            }
        }
        #endregion

        #region Methods
        void CheckData()
        {
            if(string.IsNullOrWhiteSpace(_person.Name))
            {
                throw new Exception("El nombre no puede estar vacio.");
            }
            else if(string.IsNullOrWhiteSpace(_person.LastName))
            {
                throw new Exception("El apellido no puede estar vacio.");
            }
            else if (string.IsNullOrWhiteSpace(_person.Email))
            {
                throw new Exception("El email no puede estar vacio.");
            }
            else if (string.IsNullOrWhiteSpace(_person.NumMobile))
            {
                throw new Exception("El celular no puede estar vacio.");
            }
            else if (string.IsNullOrWhiteSpace(_user.Password))
            {
                throw new Exception("La contraseña no puede estar vacio.");
            }
            else if (string.IsNullOrWhiteSpace(_user.UserName))
            {
                throw new Exception("El nombre de usuario no puede estar vacio.");
            }
            else if (string.IsNullOrWhiteSpace(_confirmPassword)
                || _confirmPassword != _user.Password)
            {
                _confirmPassword = string.Empty;
                throw new Exception("Las contraseñas no coinciden.");
            }
        }

        async void CheckUserName()
        {
            var user = await App.SqlConnection.GetAsync<User>(x => x.UserName == _user.UserName);

            if (user == null)
            {
                _user.UserName = string.Empty;
                throw new Exception("El nombre de usuario no esta disponible.");
            }
        }
        
        async void CheckEmail()
        {
            var person = await App.SqlConnection.GetAsync<Person>(x => x.Email == _person.Email);

            if (person == null)
            {
                _person.Email = string.Empty;
                throw new Exception("El email no esta disponible.");
            }
        }

        void InitialData()
        {            
            Person = new Person();
            User = new User();
            _confirmPassword = string.Empty;
            _loadingIsVisible = false;
            _loadingIsRunning = false;
        }
        #endregion
    }
}
