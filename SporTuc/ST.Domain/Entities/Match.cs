using ST.Domain.Base;
using ST.Domain.MetaData;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("Matches")]
    [MetadataType(typeof(IMatch))]
    public class Match : EntityBase
    {
        public int NumMatch { get; set; }

        public DateTime Date { get; set; }

        //Navegation Properties
        public virtual Sport Sport { get; set; }

        public virtual Team Team { get; set; }

        public virtual Team DestinationTeam { get; set; }

        public virtual StateMatch StateMatch { get; set; }

    }
}
