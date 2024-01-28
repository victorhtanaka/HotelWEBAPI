using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Quarto
    {
        [Key]
        public int NumQuarto { get; set; }

        [Required]
        [StringLength(15)]
        public string? TipoQuarto { get; set; }

        public bool Adaptado { get; set; }

        public decimal ValorQuarto { get; set; }

        public int CapacidadeQuarto { get; set; }
    }
}