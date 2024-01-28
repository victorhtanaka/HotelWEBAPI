using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HotelWEBAPI.Models
{
    public class Quarto
    {
        [Key]
        public int NumQuarto { get; set; }

        [StringLength(15)]
        public string? TipoQuarto { get; set; }

        public bool Adaptado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorQuarto { get; set; }

        public int CapacidadeQuarto { get; set; }
    }
}