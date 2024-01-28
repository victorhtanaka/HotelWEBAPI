using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class ProdutoConta
    {
        public int FkProdutoCodProduto { get; set; }
        public int FkReservaContaCodReserva { get; set; }
        public int FkReservaContaCodConta { get; set; }

        public Produto Produto { get; set; }
        public ReservaConta ReservaConta { get; set; }
    }
}