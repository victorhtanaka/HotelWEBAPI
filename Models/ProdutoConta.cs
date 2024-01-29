using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class ProdutoConta
    {
        [Key]
        [ForeignKey("Produto")]
        public int FkProdutoCodProduto { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodReserva { get; set; }
    }
}