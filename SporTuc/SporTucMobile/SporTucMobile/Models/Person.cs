using SporTucMobile.Models.Base;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace SporTucMobile.Models
{
    [Table("Persons")]
    public class Person : EntityBase
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string NumMobile { get; set; }

        //Navigation Properties
        [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
        public List<User> Users { get; set; }
    }
}
