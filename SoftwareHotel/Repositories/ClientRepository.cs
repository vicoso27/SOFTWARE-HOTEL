using SoftwareHotel.Data;
using SoftwareHotel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Client?> GetClientByIdAsync(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddClientAsync(Client client)
        {
            _context.Clientes.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateClientAsync(Client client)
        {
            var existingClient = await _context.Clientes.FindAsync(client.Id);
            if (existingClient == null) return false;

            existingClient.Nombre = client.Nombre;
            existingClient.Email = client.Email;
            existingClient.Telefono = client.Telefono;
            existingClient.DocumentoIdentidad = client.DocumentoIdentidad;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteClientAsync(int id)
        {
            var client = await _context.Clientes.FindAsync(id);
            if (client == null) return false;

            _context.Clientes.Remove(client);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
