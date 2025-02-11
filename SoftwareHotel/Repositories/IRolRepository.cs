using SoftwareHotel.Models;

namespace SoftwareHotel.Repositories
{
    public interface IRolRepository
    {
        Task<IEnumerable<Rol>> GetAllRolesAsync();
        Task<Rol?> GetRolAsync(int id);
        Task CreateRolAsync(Rol rol);
        Task UpdateRolAsync(Rol rol);
        Task DeleteRolAsync(int id);
    }
}
