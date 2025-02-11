using SoftwareHotel.Data;
using SoftwareHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace SoftwareHotel.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;

        public BookingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateBookingAsync(Booking booking)
        {
            _context.Reservas.Add(booking);  
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookingAsync(int id)
        {
            var booking = await _context.Reservas.FindAsync(id);
            if (booking != null)
            {
                _context.Reservas.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Booking?> GetBookingAsync(int id)
        {
            return await _context.Reservas.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _context.Reservas.ToListAsync();
        }

        public async Task UpdateBookingAsync(Booking booking)
        {
            var existingBooking = await _context.Reservas.FindAsync(booking.Id);

            if (existingBooking != null)
            {
                existingBooking.ClienteId = booking.ClienteId;
                existingBooking.Cliente = booking.Cliente;
                existingBooking.HabitacionId = booking.HabitacionId;
                existingBooking.Habitacion = booking.Habitacion;
                existingBooking.FechaInicio = booking.FechaInicio;
                existingBooking.FechaFin = booking.FechaFin;
                existingBooking.Estado = booking.Estado;

                await _context.SaveChangesAsync();
            }
        }
    }
}
