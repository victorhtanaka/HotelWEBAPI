using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI
{
    public class FilialQuarto
    {
        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }
        [ForeignKey("Quarto")]
        public int FkQuartoNumQuarto { get; set; }

        public Filial? Filial { get; set; }
        public Quarto? Quarto { get; set; }
    }
}