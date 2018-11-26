using GalaSoft.MvvmLight.Command;
using SporTucMobile.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region attributes
        private string _nameUser { get; set; }
        public string NameUser
        {
            get
            {
                return this._nameUser;
            }
            set
            {
                if(value != _nameUser)
                {
                    _nameUser = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _password { get; set; }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandRegister { get { return new RelayCommand(Register); } }

        public ICommand CommandForgotPassword { get { return new RelayCommand<string>(ForgotPassword); } }
        #endregion

        #region Builder
        public LoginViewModel()
        {
            InitialData();
        }
        #endregion

        #region Command
        void Register()
        {
            Application.Current.MainPage = new RegisterPage();
        }

        void ForgotPassword(string user)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        private void InitialData()
        {
            _nameUser = string.Empty;
            _password = string.Empty;
        }
        #endregion
    }
}
