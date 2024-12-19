using BackEndMVCDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndMVCDDD.Application.Interface
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients();
    }
}
