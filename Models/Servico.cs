using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Servico
    {
        [Key]
        public int CodServico { get; set; }

        [Required]
        [StringLength(150)]
        public required string DescServico { get; set; }

        public decimal ValorServico { get; set; }
    }
}