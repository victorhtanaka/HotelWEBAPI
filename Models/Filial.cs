using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Filial
    {
        public int CodFilial { get; set; }
        public string NomeFilial { get; set; }
        public string EndFilial { get; set; }
        public int Estrelas { get; set; }
    }
}