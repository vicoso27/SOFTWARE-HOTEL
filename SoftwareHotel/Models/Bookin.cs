namespace SoftwareHotel.Models
{
    public class Booking
        {
        

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public int HabitacionId { get; set; }
        public string Habitacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
