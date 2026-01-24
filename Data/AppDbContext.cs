using Microsoft.EntityFrameworkCore;
using Multimedialny_przewodnik_po_Uczelni.Models;

namespace Multimedialny_przewodnik_po_Uczelni.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<LocationNode> Nodes { get; set; }
        public DbSet<Edge> Edges { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Edge>()
                .HasOne(e => e.FromNode)
                .WithMany(n => n.OutgoingEdges)
                .HasForeignKey(e => e.FromNodeId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}