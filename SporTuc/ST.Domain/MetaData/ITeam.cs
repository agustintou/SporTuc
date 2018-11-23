using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Domain.MetaData
{
    public interface ITeam
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(25, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_Team_TeamName", IsUnique = true)]
        string TeamName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(3, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        [Index("Index_Team_Alias", IsUnique = true)]
        string Alias { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(100, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        string Logo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El Campo {0} debe ser menor a {1} caracteres")]
        string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " El campo {0} es obligatorio")]
        int Points { get; set; }
    }
}
