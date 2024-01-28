using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI
{
    public class ServicoConta
    {
        [ForeignKey("Servico")]
        public int FkServicoCodServico { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodReserva { get; set; }

        public virtual Servico? Servico { get; set; }

        public virtual ReservaConta? ReservaConta { get; set; }
    }
}