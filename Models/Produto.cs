using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Produto
    {
        [Key]
        public int CodProduto { get; set; }

        [Required]
        [StringLength(40)]
        public required string NomeProduto { get; set; }

        public decimal PrecoProduto { get; set; }
    }
}