using BackEndMVCDDD.Domain.Entities;
using System.Data.Entity;

namespace BackEndMVCDDD.Infra.Data.Context
{
    public class BackEndMVCDDDContext : DbContext
    {
        public BackEndMVCDDDContext()
            : base("BackEndMVCDDD")
        {
            
        }

        public DbSet<Client> Clients { get; set; }
    }
}
