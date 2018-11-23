using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.MetaData
{
    public interface IPerson
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(25, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(25, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_Person_Name", IsUnique = true)]
        string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_Person_Email", IsUnique = true)]
        [DataType(DataType.EmailAddress, ErrorMessage = "El formato es incorrecto")]
        string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "El formato es incorrecto")]
        string Mobile { get; set; }
    }
}
