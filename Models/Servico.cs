using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class Servico
    {
        [Key]
        public int CodServico { get; set; }

        [StringLength(150)]
        public required string DescServico { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorServico { get; set; }
    }
}