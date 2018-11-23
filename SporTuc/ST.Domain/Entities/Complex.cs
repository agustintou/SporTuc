using ST.Domain.Base;
using ST.Domain.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.Entities
{
    [Table("Complexes")]
    [MetadataType(typeof(IComplex))]
    public class Complex : EntityBase
    {
        public string ComplexName { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

    }
}
