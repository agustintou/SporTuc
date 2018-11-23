using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.MetaData
{
    public interface IStateMatch
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [Index("Index_StateMatch_Code", IsUnique = true)]
        string Code { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_StateMatch_Description", IsUnique = true)]
        string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        string Delete { get; set; }
    }
}
