using System.ComponentModel.DataAnnotations.Schema;
using SoftwareHotel.Data;

namespace SoftwareHotel.Models
{
    public class Booking 
        {
        

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public required Client Client { get; set; } 
        public int HabitacionId { get; set; }
        public required string Habitacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public required string Estado { get; set; }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
         [NotMapped] // Ignorar si no se debe mapear en la base de datos
   public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();

    }
}
