using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Cliente
    {
        [Key]
        public int CodCliente { get; set; }

        [Required]
        [StringLength(50)]
        public string? NomeCliente { get; set; }

        [StringLength(50)]
        public string? EndCliente { get; set; }

        [StringLength(30)]
        public string? NacioCliente { get; set; }

        [StringLength(30)]
        public string? EmailCliente { get; set; }

        [StringLength(16)]
        public string? TelCliente { get; set; }
    }
}