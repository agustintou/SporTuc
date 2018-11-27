using SQLite.Net.Interop;

namespace SporTucMobile.Interfaces
{
    public interface IConfig
    {
        string DirectoryDB { get; }

        ISQLitePlatform Platform { get; }
    }
}
