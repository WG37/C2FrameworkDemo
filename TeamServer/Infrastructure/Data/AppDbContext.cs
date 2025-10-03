using Microsoft.EntityFrameworkCore;

using TeamServer.Domain.Entities.Listeners;

namespace TeamServer.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<HttpListenerEntity> httpListeners;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
