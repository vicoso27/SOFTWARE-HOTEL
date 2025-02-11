using Microsoft.EntityFrameworkCore;
using SoftwareHotel.Models;

namespace SoftwareHotel.Data
{
    public class KolorinaDbContext : DbContext
    {
        public KolorinaDbContext(DbContextOptions<KolorinaDbContext> options) : base(options) { }

        // Definir las tablas como DbSet
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Room> Habitaciones { get; set; }
        public DbSet<Client> Clientes { get; set; }
        public DbSet<Booking> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
