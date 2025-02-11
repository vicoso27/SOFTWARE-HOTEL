using SoftwareHotel.Dtos;
using SoftwareHotel.Models;
using SoftwareHotel.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<User> CreateUserAsync(UserDto userDto)
        {
            var user = new User
            {
                Nombre = userDto.Nombre,
                Email = userDto.Email,
                Contraseña = userDto.Contraseña,
                RolId = userDto.RolId
            };

            await _userRepository.AddUserAsync(user);
            return user;
        }

        public async Task<bool> UpdateUserAsync(int id, UserDto userDto)
        {
            var existingUser = await _userRepository.GetUserByIdAsync(id);
            if (existingUser == null) return false;

            existingUser.Nombre = userDto.Nombre;
            existingUser.Email = userDto.Email;
            existingUser.Contraseña = userDto.Contraseña;
            existingUser.RolId = userDto.RolId;

            return await _userRepository.UpdateUserAsync(id, existingUser);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteUserAsync(id);
        }
    }
}
