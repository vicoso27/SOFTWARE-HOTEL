using SoftwareHotel.Models;
using SoftwareHotel.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public class HabitacionesService : IHabitacionesService
    {
        private readonly IRoomRepository _habitacionesRepository;

        public HabitacionesService(IRoomRepository habitacionesRepository)
        {
            _habitacionesRepository = habitacionesRepository;
        }

        public async Task<IEnumerable<Habitacion>> GetHabitacionesAsync()
        {
            return await _habitacionesRepository.GetHabitacionesAsync();
        }

        public async Task<Habitacion?> GetHabitacionByIdAsync(int id)
        {
            return await _habitacionesRepository.GetHabitacionByIdAsync(id);
        }

        public async Task<Habitacion> CreateHabitacionAsync(Habitacion habitacion)
        {
            await _habitacionesRepository.AddHabitacionAsync(habitacion);
            return habitacion;
        }

        public async Task<bool> UpdateHabitacionAsync(int id, Habitacion habitacion)
        {
            var existingHabitacion = await _habitacionesRepository.GetHabitacionByIdAsync(id);
            if (existingHabitacion == null) return false;

            existingHabitacion.Numero = habitacion.Numero;
            existingHabitacion.Tipo = habitacion.Tipo;
            existingHabitacion.Capacidad = habitacion.Capacidad;
            existingHabitacion.Precio = habitacion.Precio;
            existingHabitacion.Disponible = habitacion.Disponible;

            return await _habitacionesRepository.UpdateHabitacionAsync(existingHabitacion);
        }

        public async Task<bool> DeleteHabitacionAsync(int id)
        {
            return await _habitacionesRepository.DeleteHabitacionAsync(id);
        }
    }
}
