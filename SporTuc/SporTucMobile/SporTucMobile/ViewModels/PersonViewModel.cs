using GalaSoft.MvvmLight.Command;
using SporTucMobile.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public ICommand CommandToReturn { get { return new RelayCommand(ToReturn); } }
        #endregion

        #region Builder
        public PersonViewModel()
        {

        }
        #endregion

        #region Commands
        private void ToReturn()
        {
            Application.Current.MainPage = new LoginPage();
        }
        #endregion

        #region Methods

        #endregion
    }
}
