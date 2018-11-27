using System;
using SporTucMobile.Models;
using SporTucMobile.Services;
using SporTucMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SporTucMobile
{
    public partial class App : Application
    {
        #region Attributes
        private DataService dataService;

        #endregion
        public static int ScreenWidth;
        public static int ScreenHeight;

        public App()
        {
            InitializeComponent();

            //dataService = new DataService();
            //LoadParameters();
            MainPage = new NavigationPage(new LoginPage());
        }

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        private void LoadParameters()
        {
            var urlBase = Application.Current.Resources["URLBase"].ToString();
            var parameter = dataService.First<Parameter>(false);

            if(parameter == null)
            {
                parameter = new Parameter
                {
                    URLBase = urlBase
                };

                dataService.Insert(parameter);
            }
            else
            {
                parameter.URLBase = urlBase;
                dataService.Update(parameter);
            }
        }
        #endregion
    }
}
