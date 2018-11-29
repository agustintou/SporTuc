using SporTucMobile.Interfaces;
using SQLite;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public LoginViewModel Login { get; set; }

        public PersonViewModel Persons { get; set; }

        //public SQLiteAsyncConnection Connection { get; set; }
        #endregion

        #region Builder
        public MainViewModel()
        {
            Login = new LoginViewModel();
            Persons = new PersonViewModel();
        }
        #endregion
    }
}
