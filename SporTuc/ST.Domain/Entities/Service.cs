using ST.Domain.Base;
using ST.Domain.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("Services")]
    [MetadataType(typeof(IService))]
    public class Service : EntityBase
    {
        public int Code { get; set; }

        public string Description { get; set; }

        public bool Delete { get; set; }

        //Navigation Properties
        public ICollection<Field> Fields { get; set; }

    }
}
