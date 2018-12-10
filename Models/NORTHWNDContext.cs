using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace samplebrowser.Models
{
    public partial class NORTHWNDContext : DbContext
    {
        public NORTHWNDContext(DbContextOptions<NORTHWNDContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.OrderID).IsRequired();
            });

        }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}
