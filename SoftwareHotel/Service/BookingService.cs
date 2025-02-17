using SoftwareHotel.Models;
using SoftwareHotel.Repositories;
using SoftwareHotel.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            return await _bookingRepository.GetBookingsAsync();
        }

        public async Task<Booking?> GetBookingByIdAsync(int id)
        {
            return await _bookingRepository.GetBookingByIdAsync(id);
        }

        public async Task<Booking> CreateBookingAsync(Booking booking)
        {
            await _bookingRepository.AddBookingAsync(booking);
            return booking;
        }

        public async Task<bool> UpdateBookingAsync(int id, Booking booking)
        {
            var existingBooking = await _bookingRepository.GetBookingByIdAsync(id);
            if (existingBooking == null) return false;

            existingBooking.ClienteId = booking.ClienteId;
            existingBooking.ClienteId = booking.ClienteId;
            existingBooking.HabitacionId = booking.HabitacionId;
            existingBooking.Habitacion = booking.Habitacion;
            existingBooking.FechaInicio = booking.FechaInicio;
            existingBooking.FechaFin = booking.FechaFin;
            existingBooking.Estado = booking.Estado;

            return await _bookingRepository.UpdateBookingAsync(existingBooking);
        }

        public async Task<bool> DeleteBookingAsync(int id)
        {
            return await _bookingRepository.DeleteBookingAsync(id);
        }
    }
}
