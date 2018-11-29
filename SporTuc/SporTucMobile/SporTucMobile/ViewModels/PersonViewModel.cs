using GalaSoft.MvvmLight.Command;
using SporTucMobile.Models;
using SporTucMobile.Services;
using SporTucMobile.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class PersonViewModel : BaseViewModel
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


        private bool _isEnabled { get; set; }
        public bool IsEnabled
        {
            get
            {
                return this._isEnabled;
            }
            set
            {
                if (value != _isEnabled)
                {
                    _isEnabled = value;
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

        private bool _loadingIsRunning { get; set; }
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

        private bool _loadingIsVisible { get; set; }
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

        private bool _entryIsEnabled { get; set; }
        public bool EntryIsEnabled
        {
            get
            {
                return this._entryIsEnabled;
            }
            set
            {
                if (value != _entryIsEnabled)
                {
                    _entryIsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandToReturn { get { return new RelayCommand(ToReturn); } }

        public ICommand CommandRegister { get { return new RelayCommand(Register); } }

        public DataService _dataService { get; set; }
        #endregion

        #region Builder
        public PersonViewModel()
        {            
            InitialData();
        }
        #endregion

        #region Commands
        void ToReturn()
        {
            Application.Current.MainPage = new LoginPage();
        }

        async void Register()
        {
            LoadingIsVisible = true;
            LoadingIsRunning = true;
            EnabledData(false);

            if(CheckData())
            {
                var nowPerson = new Person
                {
                    Email = _person.Email,
                    LastName = _person.LastName,
                    Name = _person.Name,
                    NumMobile = _person.NumMobile
                };

                await App.SqlConnection.InsertAsync(nowPerson);

                var nowUser = new User
                {
                    UserName = _user.UserName,
                    Password = _user.Password,
                    Person = nowPerson,
                    Locked = false
                };

                await App.SqlConnection.InsertAsync(nowUser);
            }

            LoadingIsRunning = false;
            EnabledData(true);
        }
        #endregion

        #region Methods
        void InitialData()
        {
            _dataService = new DataService();
            Person = new Person();
            _person.Name = string.Empty;
            _person.LastName = string.Empty;
            _person.Email = string.Empty;
            _person.NumMobile = string.Empty;
            LoadingIsVisible = false;
            LoadingIsRunning = false;
            EnabledData(true);
        }

        bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(_person.Name)
                || string.IsNullOrWhiteSpace(_person.LastName)
                || string.IsNullOrWhiteSpace(_person.Email)
                || string.IsNullOrWhiteSpace(_person.NumMobile)
                || string.IsNullOrWhiteSpace(_user.UserName)
                || string.IsNullOrWhiteSpace(_user.Password)
                || string.IsNullOrWhiteSpace(_confirmPassword))
            {
                return false;
            }
            else if (_user.Password == _confirmPassword)
            {
                return true;
            }
            else
                return false;
        }

        void EnabledData(bool enabled)
        {
            EntryIsEnabled = enabled;
        }
        #endregion
    }
}
