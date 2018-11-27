using SporTucMobile.Droid.Implementations;
using SporTucMobile.Interfaces;
using SQLite.Net.Interop;

[assembly: Xamarin.Forms.Dependency(typeof(Config))]
namespace SporTucMobile.Droid.Implementations
{
    public class Config : IConfig
    {
        private string _directoryDB { get; set; }
        public string DirectoryDB
        {
            get
            {
                if (string.IsNullOrEmpty(_directoryDB))
                {
                    _directoryDB = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                }

                return _directoryDB;
            }
        }

        private ISQLitePlatform _platform { get; set; }
        public ISQLitePlatform Platform
        {
            get
            {
                if(_platform == null)
                {
                    _platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }

                return _platform;
            }
        }
    }
}