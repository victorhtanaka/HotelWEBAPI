using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI
{
    public class ReservaConta
    {
        [Key]
        public int CodReserva { get; set; }

        public DateTime DataCheckin { get; set; }

        public bool StatusReserva { get; set; }

        [StringLength(30)]
        public string TipoPagamento { get; set; }

        public DateTime DataCheckout { get; set; }

        public bool CamaAdicional { get; set; }

        [ForeignKey("Cliente")]
        public int FkClienteCodCliente { get; set; }

        [ForeignKey("Quarto")]
        public int FkQuartoNumQuarto { get; set; }

        [ForeignKey("Funcionario")]
        public int FkFuncionarioCodFuncionario { get; set; }

        [Key]
        public int CodConta { get; set; }

        public bool Pago { get; set; }

        public virtual Cliente? Cliente { get; set; }

        public virtual Quarto? Quarto { get; set; }

        public virtual Funcionario? Funcionario { get; set; }
    }
}