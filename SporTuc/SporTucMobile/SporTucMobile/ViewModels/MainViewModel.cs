namespace SporTucMobile.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public LoginViewModel Login { get; set; }
        #endregion

        #region Builder
        public MainViewModel()
        {
            //App.ScreenHeight = (int)Application.Current.MainPage.Height;
            //App.ScreenWidth = (int)Application.Current.MainPage.Width;
            Login = new LoginViewModel();
        }
        #endregion
    }
}
