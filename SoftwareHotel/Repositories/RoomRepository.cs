using Microsoft.EntityFrameworkCore;
using SoftwareHotel.Data;
using SoftwareHotel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _context;

        public RoomRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Habitacion>> GetRoomsAsync()
        {
            return await _context.Habitaciones.ToListAsync();
        }

        public async Task<Habitacion?> GetRoomByIdAsync(int id)
        {
            return await _context.Habitaciones.FindAsync(id);
        }

        public async Task AddRoomAsync(Habitacion habitacion)
        {
            await _context.Habitaciones.AddAsync(habitacion);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateRoomAsync(Habitacion habitacion)
        {
            _context.Habitaciones.Update(habitacion);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteRoomAsync(int id)
        {
            var habitacion = await _context.Habitaciones.FindAsync(id);
            if (habitacion == null) return false;

            _context.Habitaciones.Remove(habitacion);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<IEnumerable<Habitacion>> GetHabitacionesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Habitacion?> GetHabitacionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddHabitacionAsync(Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateHabitacionAsync(Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHabitacionAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
