using SoftwareHotel.Data;
using SoftwareHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace SoftwareHotel.Repositories
{
    public class RolRepository : IRolRepository
    {
        private readonly AppDbContext _context;

        public RolRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rol>> GetAllRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Rol?> GetRolAsync(int id)
        {
            return await _context.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task CreateRolAsync(Rol rol)
        {
            _context.Roles.Add(rol);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRolAsync(Rol rol)
        {
            var existingRol = await _context.Roles.FindAsync(rol.Id);

            if (existingRol != null)
            {
                existingRol.Nombre = rol.Nombre;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteRolAsync(int id)
        {
            var rol = await _context.Roles.FindAsync(id);
            if (rol != null)
            {
                _context.Roles.Remove(rol);
                await _context.SaveChangesAsync();
            }
        }
    }
}
