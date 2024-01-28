using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class Prato
    {
        [Key]
        public int CodPrato { get; set; }

        [Required]
        [StringLength(100)]
        public required string NomePrato { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorPrato { get; set; }
    }
}