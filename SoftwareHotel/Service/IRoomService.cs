using SoftwareHotel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public interface IHabitacionesService
    {
        Task<IEnumerable<Habitacion>> GetHabitacionesAsync();
        Task<Habitacion?> GetHabitacionByIdAsync(int id);
        Task<Habitacion> CreateHabitacionAsync(Habitacion habitacion);
        Task<bool> UpdateHabitacionAsync(int id, Habitacion habitacion);
        Task<bool> DeleteHabitacionAsync(int id);
    }
}
