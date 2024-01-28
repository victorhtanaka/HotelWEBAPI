using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CodProduto { get; set; }

        [Required]
        [StringLength(40)]
        public required string NomeProduto { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecoProduto { get; set; }
    }
}