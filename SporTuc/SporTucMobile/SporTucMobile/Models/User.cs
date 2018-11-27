using SporTucMobile.Models.Base;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SporTucMobile.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Locked { get; set; }

        public override int GetHashCode()
        {
            return (int)Id;
        }

        //Navigations properties
        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public Person Person { get; set; }

    }
}
