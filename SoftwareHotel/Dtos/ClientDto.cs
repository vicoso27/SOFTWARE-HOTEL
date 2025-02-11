namespace SoftwareHotel.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Telefono { get; set; }
        public required string documento_Identidad { get; set; }  
    }
}
