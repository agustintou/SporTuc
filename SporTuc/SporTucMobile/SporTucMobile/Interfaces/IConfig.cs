using SQLite;

namespace SporTucMobile.Interfaces
{
    public interface IConfig
    {
        SQLiteAsyncConnection GetConnection();
    }
}
