using ST.Domain.Base;
using ST.Domain.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("Ratings")]
    [MetadataType(typeof(IRanking))]
    public class Ranking : EntityBase
    {
        public int Score { get; set; }

        public DateTime Date { get; set; }

        //Navigation Properties
        public virtual Complex Complex { get; set; }

        public virtual Person Person { get; set; }

    }
}
