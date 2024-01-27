using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace webAPI2
{
    public class EmployeeContext : DbContext
    {
        public DbSet<MEmployee> mEmployees {get; set;} = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            OptionsBuilder.UseSqlServer(@"Server=.\;Database=Sextou;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}