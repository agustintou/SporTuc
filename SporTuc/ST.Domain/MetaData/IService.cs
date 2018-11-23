using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.MetaData
{
    public interface IService
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [Index("Index_Service_Code", IsUnique = true)]
        int Code { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_Service_Description", IsUnique = true)]
        string Description { get; set; }

        string Delete { get; set; }
    }
}
