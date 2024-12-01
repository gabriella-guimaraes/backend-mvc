

using BackEndMVCDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BackEndMVCDDD.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Price)
                .IsRequired();

            //Relacionamento com a entity de client (um client tem muitos products) - Foreing Key
            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientId);
        }
    }
}
