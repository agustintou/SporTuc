using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.MetaData
{
    public interface IComplex
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(30, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_Complex_ComplexName", IsUnique = true)]
        string ComplexName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(100, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        string Logo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        string Description { get; set; }
    }
}
