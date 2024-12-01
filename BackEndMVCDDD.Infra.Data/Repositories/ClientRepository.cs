
using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Domain.Interfaces;

namespace BackEndMVCDDD.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository //Repositório especializado
    {
        //Usar para buscar mais específicas
    }
}
