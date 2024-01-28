using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI
{
    public class HotelContext : DbContext
    {
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<ReservaConta> ReservasContas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<FilialQuarto> FiliaisQuartos { get; set; }
        public DbSet<ProdutoConta> ProdutosContas { get; set; }
        public DbSet<PratoConta> PratosContas { get; set; }
        public DbSet<ServicoConta> ServicosContas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=.\;Database=HotelWEBAPI;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}