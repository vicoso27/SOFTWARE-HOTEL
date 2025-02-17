using Microsoft.AspNetCore.Identity;

namespace SoftwareHotel.Models
{
    public class Rol : IdentityRole<int> 
    {
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public int Id { get; set; }
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        public required string Nombre { get; set; }


        public ICollection<Usuario>? Usuarios { get; set; }
        public DateTime CreatedAt { get; internal set; }
    }
}
