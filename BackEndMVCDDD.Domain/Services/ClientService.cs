using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Domain.Interfaces.Services;
using BackEndMVCDDD.Domain.Interfaces.Repositories;

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
    }
}
