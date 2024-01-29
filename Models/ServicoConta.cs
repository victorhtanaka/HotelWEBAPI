using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class ServicoConta
    {
        [Key]
        [ForeignKey("Servico")]
        public int FkServicoCodServico { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodReserva { get; set; }
    }
}