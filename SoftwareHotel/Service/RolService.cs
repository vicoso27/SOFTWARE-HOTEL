using SoftwareHotel.Models;
using SoftwareHotel.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;

        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public async Task<IEnumerable<Rol>> GetAllRolesAsync()
        {
            return await _rolRepository.GetAllRolesAsync();
        }

        public async Task<Rol?> GetRolByIdAsync(int id)
        {
            return await _rolRepository.GetRolAsync(id);
        }

        public async Task<Rol> CreateRolAsync(Rol rol)
        {
            await _rolRepository.CreateRolAsync(rol);
            return rol;
        }

        public async Task<bool> UpdateRolAsync(int id, Rol rol)
        {
            var existingRol = await _rolRepository.GetRolAsync(id);
            if (existingRol == null) return false;

            existingRol.Nombre = rol.Nombre;

            await _rolRepository.UpdateRolAsync(existingRol);
            return true;
        }

        public async Task<bool> DeleteRolAsync(int id)
        {
            await _rolRepository.DeleteRolAsync(id);
            return true;
        }
    }
}
