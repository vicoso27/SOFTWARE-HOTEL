using SoftwareHotel.Data;
using SoftwareHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace SoftwareHotel.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Client?> GetClientAsync(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task CreateClientAsync(Client client)
        {
            _context.Clientes.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientAsync(Client client)
        {
            var existingClient = await _context.Clientes.FindAsync(client.Id);

            if (existingClient != null)
            {
                existingClient.Nombre = client.Nombre;
                existingClient.Email = client.Email;
                existingClient.Telefono = client.Telefono;
                existingClient.DocumentoIdentidad = client.DocumentoIdentidad;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteClientAsync(int id)
        {
            var client = await _context.Clientes.FindAsync(id);
            if (client != null)
            {
                _context.Clientes.Remove(client);
                await _context.SaveChangesAsync();
            }
        }
    }
}
