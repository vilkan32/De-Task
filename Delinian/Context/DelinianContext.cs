using Delinian.Models;
using Microsoft.EntityFrameworkCore;

namespace Delinian.Context
{
    public class DelinianContext : DbContext
    {
        public DelinianContext() { }

        public virtual DbSet<Person> People { get; set; }

    }
}
