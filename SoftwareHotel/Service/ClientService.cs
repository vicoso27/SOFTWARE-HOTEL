using SoftwareHotel.Models;
using SoftwareHotel.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwareHotel.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _clientRepository.GetClientsAsync();
        }

        public async Task<Client?> GetClientByIdAsync(int id)
        {
            return await _clientRepository.GetClientByIdAsync(id);
        }

        public async Task<Client> CreateClientAsync(Client client)
        {
            await _clientRepository.AddClientAsync(client);
            return client;
        }

        public async Task<bool> UpdateClientAsync(int id, Client client)
        {
            var existingClient = await _clientRepository.GetClientByIdAsync(id);
            if (existingClient == null) return false;

            existingClient.Nombre = client.Nombre;
            existingClient.Email = client.Email;
            existingClient.Telefono = client.Telefono;
            existingClient.DocumentoIdentidad = client.DocumentoIdentidad;

            return await _clientRepository.UpdateClientAsync(existingClient);
        }

        public async Task<bool> DeleteClientAsync(int id)
        {
            return await _clientRepository.DeleteClientAsync(id);
        }
    }
}
