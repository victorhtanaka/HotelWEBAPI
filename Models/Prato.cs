using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class Prato
    {
        public int CodPrato { get; set; }
        public string NomePrato { get; set; }
        public decimal ValorPrato { get; set; }
    }
}