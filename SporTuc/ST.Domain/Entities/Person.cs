using ST.Domain.Base;
using ST.Domain.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("Persons")]
    [MetadataType(typeof(IPerson))]
    public class Person : EntityBase
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        //Navigation properties
        public ICollection<User> Users { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
