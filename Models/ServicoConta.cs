using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class ServicoConta
    {
        public int FkServicoCodServico { get; set; }
        public int FkReservaContaCodReserva { get; set; }
        public int FkReservaContaCodConta { get; set; }

        public Servico Servico { get; set; }
        public ReservaConta ReservaConta { get; set; }
    }
}