using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.MetaData
{
    public interface IUser
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(15, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_User_UserName", IsUnique = true)]
        string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(15, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        string Password { get; set; }

        bool Locked { get; set; }
    }
}
