using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class ReservaConta
    {
        [Key]
        public int CodReserva { get; set; }

        public DateOnly DataCheckin { get; set; }

        public bool StatusReserva { get; set; }

        [StringLength(30)]
        public string? TipoPagamento { get; set; }

        public DateOnly DataCheckout { get; set; }

        public bool CamaAdicional { get; set; }

        [ForeignKey("Cliente")]
        public int FkClienteCodCliente { get; set; }

        [ForeignKey("Quarto")]
        public int FkQuartoNumQuarto { get; set; }

        [ForeignKey("Funcionario")]
        public int FkFuncionarioCodFuncionario { get; set; }

        public bool Pago { get; set; }
    }
}