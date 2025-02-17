using SoftwareHotel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetBookingsAsync();
        Task<Booking?> GetBookingByIdAsync(int id);
        Task<Booking> CreateBookingAsync(Booking booking);
        Task<bool> UpdateBookingAsync(int id, Booking booking);
        Task<bool> DeleteBookingAsync(int id);
    }
}
