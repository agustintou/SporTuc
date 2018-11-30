using GalaSoft.MvvmLight.Command;
using Rg.Plugins.Popup.Services;
using SporTucMobile.Interfaces;
using SporTucMobile.Models;
using SporTucMobile.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region attributes
        public User _user { get; set; }
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
        #endregion

        #region Properties
        public ICommand CommandRegister { get { return new RelayCommand(Register); } }

        public ICommand CommandForgotPassword { get { return new RelayCommand(ForgotPassword); } }

        public ICommand CommandLogin { get { return new RelayCommand(Login); } }

        public ForgotPasswordViewModel ForgotPasswordVM { get; set; }

        private readonly IMessage _message;
        #endregion

        #region Builder
        public LoginViewModel()
        {
            _message = DependencyService.Get<IMessage>();
            InitialData();
        }
        #endregion

        #region Command
        void Register()
        {
            Application.Current.MainPage = new RegisterPage();
        }

        async void ForgotPassword()
        {
            if(ForgotPasswordVM == null)
            {
                ForgotPasswordVM = new ForgotPasswordViewModel();
            }

            await PopupNavigation.Instance.PushAsync(new ForgotPasswordPage());
        }

        async void Login()
        {
            try
            {
                CheckData();

                if(_user.UserName == "admin"
                    && _user.Password == "123")
                {
                    ToAccess();
                }
                else
                {
                    CheckNowUser();

                    ToAccess();
                }
            }
            catch (Exception ex)
            {
                await this._message.MessageShowAsync("Mensaje", ex.Message);
            }
        }
        #endregion

        #region Methods
        private void InitialData()
        {
            User = new User();
        }

        void CheckData()
        {
            if(string.IsNullOrWhiteSpace(_user.UserName))
            {
                throw new Exception("El nombre de usuario no puede estar vacio.");
            }
            else if(string.IsNullOrWhiteSpace(_user.Password))
            {
                throw new Exception("La contraseña no puede estar vacia.");
            }
        }

        async void CheckNowUser()
        {
            var user = await App.SqlConnection.GetAsync<User>(x => x.UserName == _user.UserName && x.Password == _user.Password);

            if(user == null)
            {
                User.Password = string.Empty;
                User.UserName = string.Empty;
                throw new Exception("El usuario y contraseña no coinciden. Intente de nuevo");
            }
        }

        void ToAccess()
        {
            App.Current.MainPage = new MainPage();
        }
        #endregion
    }
}
