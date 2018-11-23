using ST.Domain.Base;
using ST.Domain.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("Fields")]
    [MetadataType(typeof(IField))]
    public class Field : EntityBase
    {
        public int Quantity { get; set; }

        //Navigation Properties
        public virtual Sport Sport { get; set; }

        public virtual Complex Complex { get; set; }

        public ICollection<Service> Services { get; set; }

    }
}
