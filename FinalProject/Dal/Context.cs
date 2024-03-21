using Microsoft.EntityFrameworkCore;

namespace FinalProject.Dal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<>
    }
}
