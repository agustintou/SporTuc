using SporTucMobile.Models.Base;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SporTucMobile.Models
{
    public class User : EntityBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Locked { get; set; }

        //Navigations properties
        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public Person Person { get; set; }

    }
}
