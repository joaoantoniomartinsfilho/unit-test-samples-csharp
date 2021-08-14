using Microsoft.EntityFrameworkCore;
using OrderEcommerce.Domain.Entities.CustomerAggregate;
using OrderEcommerce.Domain.Entities.OrderAggregate;
using OrderEcommerce.Infra.Context.MappingConfiguration;
using System;

namespace OrderEcommerce.Infra.Context
{
    public class OrderEcommerceDbContext : DbContext
    {
        DbSet<Order> Orders { get; set; }
        DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {                
                modelBuilder.Entity(entity.Name).Property("CreatedAt").IsRequired();
                modelBuilder.Entity(entity.Name).Property("UpdatedAt");                
            }


            modelBuilder.ApplyConfiguration(new AddressMappingConfiguration());
            modelBuilder.ApplyConfiguration(new EmailMappingConfiguration());
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                    entry.Property("CreatedAt").CurrentValue = DateTime.UtcNow;

                if (entry.State == EntityState.Modified)
                    entry.Property("UpdatedAt").CurrentValue = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }
    }
}
