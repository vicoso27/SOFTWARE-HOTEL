using SoftwareHotel.Dtos;
using SoftwareHotel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User?> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(UserDto userDto);
        Task<bool> UpdateUserAsync(int id, UserDto userDto);
        Task<bool> DeleteUserAsync(int id);
    }
}
