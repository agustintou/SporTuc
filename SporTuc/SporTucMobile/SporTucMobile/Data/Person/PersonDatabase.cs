using SQLite;
using SporTucMobile;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SporTucMobile.Data.Person
{
    public class PersonDatabase
    {
        readonly SQLiteAsyncConnection database;

        public PersonDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Models.Person>().Wait();
        }


        public Task<List<Models.Person>> Get()
        {
            return database.Table<Models.Person>().ToListAsync();
        }

        public Task<Models.Person> GetToId(long id)
        {
            return database.Table<Models.Person>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<int> Save(Models.Person entity)
        {
            if(entity.Id == 0)
            {
                return database.InsertAsync(entity);
            }
            else
            {
                return database.UpdateAsync(entity);
            }
        }

        public Task<int> Delete(Models.Person entity)
        {
            return database.DeleteAsync(entity);
        }
    }
}
