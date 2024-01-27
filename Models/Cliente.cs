using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public string EndCliente { get; set; }
        public string NacioCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelCliente { get; set; }
    }
}