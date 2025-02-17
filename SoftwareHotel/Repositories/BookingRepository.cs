using SoftwareHotel.Data;
using SoftwareHotel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;

        public BookingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            return await _context.Reservas.ToListAsync();
        }

        public async Task<Booking?> GetBookingByIdAsync(int id)
        {
            return await _context.Reservas.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddBookingAsync(Booking booking)
        {
            _context.Reservas.Add(booking);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateBookingAsync(Booking booking)
        {
            var existingBooking = await _context.Reservas.FindAsync(booking.Id);
            if (existingBooking == null) return false;

            existingBooking.ClienteId = booking.ClienteId;
            existingBooking.ClienteId = booking.ClienteId;
            existingBooking.HabitacionId = booking.HabitacionId;
            existingBooking.Habitacion = booking.Habitacion;
            existingBooking.FechaInicio = booking.FechaInicio;
            existingBooking.FechaFin = booking.FechaFin;
            existingBooking.Estado = booking.Estado;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteBookingAsync(int id)
        {
            var booking = await _context.Reservas.FindAsync(id);
            if (booking == null) return false;

            _context.Reservas.Remove(booking);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
