namespace SoftwareHotel.Services
{
    public class User
    {
        public string? Nombre { get; internal set; }
        public string? Email { get; internal set; }
        public string? Contraseña { get; internal set; }
        public int RolId { get; internal set; }
    }
}