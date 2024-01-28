using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class ReservaConta
    {
        public int CodReserva { get; set; }
        public DateOnly DataCheckin { get; set; }
        public bool StatusReserva { get; set; }
        public string TipoPagamento { get; set; }
        public DateOnly DataCheckout { get; set; }
        public bool CamaAdicional { get; set; }
        public int FkClienteCodCliente { get; set; }
        public int FkQuartoNumQuarto { get; set; }
        public int FkFuncionarioCodFuncionario { get; set; }
        public int CodConta { get; set; }
        public bool Pago { get; set; }

        public Cliente Cliente { get; set; }
        public Quarto Quarto { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}