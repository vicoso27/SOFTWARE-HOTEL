using SoftwareHotel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public interface IRolService
    {
        Task<IEnumerable<Rol>> GetAllRolesAsync();
        Task<Rol?> GetRolByIdAsync(int id);
        Task<Rol> CreateRolAsync(Rol rol);
        Task<bool> UpdateRolAsync(int id, Rol rol);
        Task<bool> DeleteRolAsync(int id);
    }
}
