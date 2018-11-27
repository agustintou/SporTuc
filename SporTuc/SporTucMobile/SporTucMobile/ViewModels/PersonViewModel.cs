using GalaSoft.MvvmLight.Command;
using SporTucMobile.Models;
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
                    _isEnabled = CheckData();
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
                    _isEnabled = CheckData();
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
        #endregion

        #region Properties
        public ICommand CommandToReturn { get { return new RelayCommand(ToReturn); } }

        public ICommand CommandRegister { get { return new RelayCommand(Register); } }
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

        private void Register()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        void InitialData()
        {
            _isEnabled = false;
        }

        bool CheckData()
        {
            if (!string.IsNullOrWhiteSpace(_person.Name)
                && string.IsNullOrWhiteSpace(_person.LastName)
                && !string.IsNullOrWhiteSpace(_person.Email)
                && !string.IsNullOrWhiteSpace(_person.NumMobile)
                && !string.IsNullOrWhiteSpace(_user.UserName)
                && !string.IsNullOrWhiteSpace(_user.Password))
                return true;

            return false;
        }
        #endregion
    }
}
