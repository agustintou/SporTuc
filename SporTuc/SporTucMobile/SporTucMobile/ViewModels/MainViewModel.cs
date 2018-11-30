using SporTucMobile.Interfaces;
using SporTucMobile.Views;
using SQLite;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public LoginViewModel Login { get; set; }

        public RegisterViewModel RegisterVM { get; set; }

        #endregion

        #region Builder
        public MainViewModel()
        {
            Login = new LoginViewModel();
            RegisterVM = new RegisterViewModel();
        }
        #endregion
    }
}
