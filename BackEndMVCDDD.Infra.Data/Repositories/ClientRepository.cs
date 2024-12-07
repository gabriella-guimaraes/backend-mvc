
using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Domain.Interfaces;

namespace BackEndMVCDDD.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, Domain.Interfaces.ClientRepository //Repositório especializado
    {
        //Usar para buscar mais específicas
    }
}
