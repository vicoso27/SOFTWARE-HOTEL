namespace SoftwareHotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }
    }
}
