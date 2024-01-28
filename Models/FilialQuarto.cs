using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class FilialQuarto
    {
        public int FkFilialCodFilial { get; set; }
        public int FkQuartoNumQuarto { get; set; }

        public Filial Filial { get; set; }
        public Quarto Quarto { get; set; }
    }
}