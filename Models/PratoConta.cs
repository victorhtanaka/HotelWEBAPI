using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class PratoConta
    {
        public int FkPratoCodPrato { get; set; }
        public int FkReservaContaCodReserva { get; set; }
        public int FkReservaContaCodConta { get; set; }

        public Prato Prato { get; set; }
        public ReservaConta ReservaConta { get; set; }
    }
}