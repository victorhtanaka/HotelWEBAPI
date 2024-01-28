using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI.Models
{
    public class HotelContext : DbContext
    {
        public DbSet<Quarto> Quartos { get; set; } = null!;
        public DbSet<ReservaConta> ReservasContas { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<Filial> Filiais { get; set; } = null!;
        public DbSet<Prato> Pratos { get; set; } = null!;
        public DbSet<Servico> Servicos { get; set; } = null!;
        public DbSet<FilialQuarto> FiliaisQuartos { get; set; } = null!;
        public DbSet<ProdutoConta> ProdutosContas { get; set; } = null!;
        public DbSet<PratoConta> PratosContas { get; set; } = null!;
        public DbSet<ServicoConta> ServicosContas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=HotelWEBAPI;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}