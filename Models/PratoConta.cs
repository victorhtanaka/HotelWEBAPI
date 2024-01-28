using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI
{
    public class PratoConta
    {
        [ForeignKey("Prato")]
        public int FkPratoCodPrato { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodReserva { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodConta { get; set; }

        public virtual Prato? Prato { get; set; }

        public virtual ReservaConta? ReservaConta { get; set; }
    }
}