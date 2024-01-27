using Microsoft.EntityFrameworkCore;

namespace webAPI2
{
    public class EmployeeContext : DbContext
    {
        public DbSet<MEmployee> mEmployees {get; set;} = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Sextou;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}