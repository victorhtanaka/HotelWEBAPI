using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI
{
    public class ProdutoConta
    {
        [Key]
        [ForeignKey("Produto")]
        public int FkProdutoCodProduto { get; set; }

        [ForeignKey("ReservaConta")]
        public int FkReservaContaCodReserva { get; set; }

        public virtual Produto? Produto { get; set; }

        public virtual ReservaConta? ReservaConta { get; set; }
    }
}