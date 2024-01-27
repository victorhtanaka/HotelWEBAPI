using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class Produto
    {
        public int CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
    }
}