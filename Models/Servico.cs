using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class Servico
    {
        public int CodServico { get; set; }
        public string DescServico { get; set; }
        public decimal ValorServico { get; set; }
    }
}