using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Prato
    {
        [Key]
        public int CodPrato { get; set; }

        [Required]
        [StringLength(100)]
        public required string NomePrato { get; set; }

        public decimal ValorPrato { get; set; }
    }
}