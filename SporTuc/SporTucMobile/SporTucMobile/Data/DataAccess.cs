using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SporTucMobile.Data
{
    public class DataAccess
    {
        //private SQLiteConnection connection;

        //public DataAccess()
        //{
        //    var nameDB = "SporTuc.db3";

        //    var config = DependencyService.Get<IConfig>();
        //    connection = new SQLiteConnection(config.Platform,
        //        System.IO.Path.Combine(config.DirectoryDB, nameDB));

        //    connection.CreateTable<Parameter>();
        //    connection.CreateTable<Person>();
        //    connection.CreateTable<User>();
        //}

        //public void Insert<T>(T model)
        //{
        //    connection.Insert(model);
        //}

        //public void Update<T>(T model)
        //{
        //    connection.Update(model);
        //}

        //public void Delete<T>(T model)
        //{
        //    connection.Delete(model);
        //}

        //public T First<T>(bool WithChildren) where T : class
        //{
        //    if(WithChildren)
        //    {
        //        return connection.GetAllWithChildren<T>().FirstOrDefault();
        //    }
        //    else
        //    {
        //        return connection.Table<T>().FirstOrDefault();
        //    }
        //}

        //public List<T> Get<T>(bool WithChildren) where T : class
        //{
        //    if(WithChildren)
        //    {
        //        return connection.GetAllWithChildren<T>().ToList();
        //    }
        //    else
        //    {
        //        return connection.Table<T>().ToList();
        //    }
        //}

        //public T Find<T>(int pk, bool WithChildren) where T : class
        //{
        //    if(WithChildren)
        //    {
        //        return connection.GetAllWithChildren<T>().FirstOrDefault(x => x.GetHashCode() == pk);
        //    }
        //    else
        //    {
        //        return connection.Table<T>().FirstOrDefault(x => x.GetHashCode() == pk);
        //    }
        //}
    }
}
