using Delinian.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Delinian.Context
{
    public class DelinianContext : DbContext
    {

        public DelinianContext(DbContextOptions options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            }
        }
        public virtual DbSet<Person> People { get; set; }

    }
}
