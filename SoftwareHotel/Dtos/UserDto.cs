namespace SoftwareHotel.Dtos
{
    public class UserDto
    {
        public required string Nombre { get; set; }
        public required string Email { get; set; }
        public required string Contraseña { get; set; }
        public int RolId { get; set; }
        public object Id { get; internal set; }
    }
}
