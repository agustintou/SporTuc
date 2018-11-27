using SporTucMobile.Models.Base;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace SporTucMobile.Models
{
    [Table("Persons")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string NumMobile { get; set; }

        public override int GetHashCode()
        {
            return (int)Id;
        }

        //Navigation Properties
        [OneToMany]
        public List<User> Users { get; set; }
    }
}
