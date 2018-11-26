using SporTucMobile.Models.Base;
using System.Collections.Generic;

namespace SporTucMobile.Models
{
    public class Person : DtoBase
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string NumMobile { get; set; }

        //Navigation Properties
        public ICollection<User> Users { get; set; }
    }
}
