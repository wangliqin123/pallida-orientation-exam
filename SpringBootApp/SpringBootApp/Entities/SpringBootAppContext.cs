using Microsoft.EntityFrameworkCore;
using SpringBootApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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