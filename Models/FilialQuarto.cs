using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class FilialQuarto
    {
        [Key]
        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }
        
        [ForeignKey("Quarto")]
        public int FkQuartoNumQuarto { get; set; }
    }
}