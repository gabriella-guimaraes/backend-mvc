using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Domain.Interfaces.Services;
using BackEndMVCDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BackEndMVCDDD.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
            : base(clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return clients.Where(c => c.SpecialClient(c));
        }
    }
}
