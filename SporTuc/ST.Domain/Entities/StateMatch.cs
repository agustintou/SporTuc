using ST.Domain.Base;
using ST.Domain.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("StateMatches")]
    [MetadataType(typeof(IStateMatch))]
    public class StateMatch : EntityBase
    {
        public int Code { get; set; }

        public string Description { get; set; }

        public bool Delete { get; set; }

    }
}
