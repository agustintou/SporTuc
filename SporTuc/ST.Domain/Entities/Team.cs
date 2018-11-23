using ST.Domain.Base;
using ST.Domain.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("Teams")]
    [MetadataType(typeof(ITeam))]
    public class Team : EntityBase
    {
        public string TeamName { get; set; }

        public string Alias { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public int Points { get; set; }

        //Navigation Properties
        public ICollection<Person> Persons { get; set; }
    }
}
