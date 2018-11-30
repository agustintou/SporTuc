using SporTucMobile.Data.Person;
using SporTucMobile.Interfaces;
using SporTucMobile.Services;
using SporTucMobile.Views;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SporTucMobile
{
    public partial class App : Application
    {
        #region Attributes
        static SQLiteAsyncConnection sqlConnection;       
        #endregion

        public static int ScreenWidth;
        public static int ScreenHeight;

        public App()
        {
            DependencyService.Register<IMessage, MessageService>();

            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
        
        public static SQLiteAsyncConnection SqlConnection
        {
            get
            {
                if(sqlConnection == null)
                {
                    sqlConnection = DependencyService.Get<IConfig>().GetConnection();
                }

                return sqlConnection;
            }
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
        #endregion
    }
}
