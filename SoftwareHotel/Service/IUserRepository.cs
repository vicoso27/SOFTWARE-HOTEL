
namespace SoftwareHotel.Services
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);
        Task<User?> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<bool> UpdateUserAsync(int id, User existingUser);
    }
}