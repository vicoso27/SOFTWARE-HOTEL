namespace SoftwareHotel.Dtos
{
    public class RoomDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Tipo { get; set; }
        public required string Capacidad { get; set; }
        public int Precio { get; set; }
        public required string Disponible { get; set; }


    }
}
