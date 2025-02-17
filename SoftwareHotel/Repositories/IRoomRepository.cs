using SoftwareHotel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Habitacion>> GetHabitacionesAsync();
        Task<Habitacion?> GetHabitacionByIdAsync(int id);
        Task AddHabitacionAsync(Habitacion habitacion);
        Task<bool> UpdateHabitacionAsync(Habitacion habitacion);
        Task<bool> DeleteHabitacionAsync(int id);
    }
}