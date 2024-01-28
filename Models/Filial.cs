using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Filial
    {
        [Key]
        public int CodFilial { get; set; }

        [StringLength(50)]
        public required string NomeFilial { get; set; }

        [StringLength(100)]
        public required string EndFilial { get; set; }

        public int Estrelas { get; set; }
    }
}