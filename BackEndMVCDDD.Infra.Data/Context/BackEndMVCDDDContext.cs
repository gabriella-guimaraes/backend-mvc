using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BackEndMVCDDD.Infra.Data.Context
{
    public class BackEndMVCDDDContext : DbContext
    {
        public BackEndMVCDDDContext()
            : base("BackEndMVCDDD")
        {
            
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Remove pré configuração que pluraliza os nomes das tabelas ao serem 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Remove pré configuração de exclusão em cascada (um para muitos)
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Remove pré configuração de exclusão em cascada (muitos para muitos)
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Toda vez que tivermos uma entidade, o Contexto entederá que Nome + Id será uma primaryKey
            modelBuilder.Properties()
                .Where(prop => prop.Name == prop.ReflectedType.Name + "Id")
                .Configure(prop => prop.IsKey());

            // Padronização varchar para strings
            modelBuilder.Properties<string>()
                .Configure(prop => prop.HasColumnType("varchar"));

            // Padronização de tamanho para strings
            modelBuilder.Properties<string>()
                .Configure(prop => prop.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClientConfiguration());

        }
        // Pré configuração para o campo de DateTime no momento de mudanças
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("SubscriptionDate") != null))
            {
                // Adicionando um cadastro
                if(entry.State == EntityState.Added)
                {
                    entry.Property("SubscriptionDate").CurrentValue = DateTime.Now;
                }

                // Modificando um cadastro
                if(entry.State == EntityState.Modified)
                {
                    entry.Property("SubscriptionDate").IsModified = false;
                }
            
            }
            return base.SaveChanges();
        }
    }
}
