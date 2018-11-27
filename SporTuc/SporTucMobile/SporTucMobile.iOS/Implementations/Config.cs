using SporTucMobile.Interfaces;
using SporTucMobile.iOS.Implementations;
using SQLite.Net.Interop;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(Config))]
namespace SporTucMobile.iOS.Implementations
{
    public class Config : IConfig
    {
        private string _directoryDB { get; set; }
        public string DirectoryDB
        {
            get
            {
                if(string.IsNullOrEmpty(_directoryDB))
                {
                    var directory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    _directoryDB = System.IO.Path.Combine(directory, "..", "Library");
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
                    _platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }

                return _platform;
            }
        }
    }
}