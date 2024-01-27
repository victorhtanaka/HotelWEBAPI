using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class Quarto
    {
        public int NumQuarto { get; set; }
        public string TipoQuarto { get; set; }
        public bool Adaptado { get; set; }
        public decimal ValorQuarto { get; set; }
        public int CapacidadeQuarto { get; set; }
    }
}