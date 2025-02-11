using Microsoft.EntityFrameworkCore;
using SoftwareHotel.Models;

namespace SoftwareHotel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Definir las tablas como DbSet
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }  // Corregido a plural
        public DbSet<Room> Habitaciones { get; set; }
        public DbSet<Client> Clientes { get; set; }
        public DbSet<Booking> Reservas { get; set; }  // Se usa "Reservas" en lugar de "Booking"
        public object Rol { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
