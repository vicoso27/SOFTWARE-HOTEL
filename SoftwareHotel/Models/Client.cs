using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareHotel.Models
{
    public class Client
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Email { get; set; }
        public required string Telefono { get; set; }
        public required string DocumentoIdentidad { get; set; }
        [NotMapped]  // No se incluirá en la base de datos
    public required object CreatedAt { get; set; }
        public required ICollection<Booking> Bookings { get; set; }
        
    }
}
