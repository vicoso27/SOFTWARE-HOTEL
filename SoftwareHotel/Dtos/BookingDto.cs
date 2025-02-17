namespace SoftwareHotel.Dtos
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int clienteId { get; set; }
        public int HabitacionId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public required string Estado { get; set; }

    }
}
