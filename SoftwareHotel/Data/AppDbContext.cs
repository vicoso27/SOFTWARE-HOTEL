using Microsoft.EntityFrameworkCore;
using SoftwareHotel.Models;

namespace SoftwareHotel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }  
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Client> Clientes { get; set; }
        public DbSet<Booking> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Habitacion>(entity =>
            {
                entity.ToTable("habitaciones");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasColumnName("id_serial")
                    .UseIdentityColumn();
                
                entity.Property(e => e.Numero).HasColumnName("numero");
                entity.Property(e => e.Tipo).HasColumnName("tipo");
                entity.Property(e => e.Capacidad).HasColumnName("capacidad");
                entity.Property(e => e.Precio).HasColumnName("precio");
                entity.Property(e => e.Disponible).HasColumnName("disponible");
            });

            modelBuilder.Entity<Rol>().HasData(
                new Rol { Id = 1, Nombre = "Admin", NormalizedName = "ADMIN" },
                new Rol { Id = 2, Nombre = "Recepcionista", NormalizedName = "RECEPCIONISTA" },
                new Rol { Id = 3, Nombre = "Cliente", NormalizedName = "CLIENTE" }
            );
        }
    }
}