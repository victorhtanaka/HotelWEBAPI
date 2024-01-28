using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class PratoConta
    {
        [Key]
        [ForeignKey("Prato")]
        public int FkPratoCodPrato { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodReserva { get; set; }

        public virtual Prato? Prato { get; set; }

        public virtual ReservaConta? ReservaConta { get; set; }
    }
}