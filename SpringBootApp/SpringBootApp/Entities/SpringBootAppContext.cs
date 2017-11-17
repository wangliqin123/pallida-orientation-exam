using Microsoft.EntityFrameworkCore;
using SpringBootApp.Models;

namespace SpringBootApp.Entities
{
    public class SpringBootAppContext : DbContext
    {       
        public SpringBootAppContext(DbContextOptions<SpringBootAppContext> options) : base(options)
        {
        }

        public DbSet<LicencePlate> LicenePlates { get; set; }
    }
}