using BackEndMVCDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndMVCDDD.Domain.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        // Regra de negócio
        IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients); // retorna uma lista apenas dos clientes especiais
    }
}
