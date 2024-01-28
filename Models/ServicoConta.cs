using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI
{
    public class ServicoConta
    {
        [Key]
        [ForeignKey("Servico")]
        public int FkServicoCodServico { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodReserva { get; set; }

        public virtual Servico? Servico { get; set; }

        public virtual ReservaConta? ReservaConta { get; set; }
    }
}