using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderEcommerce.Domain.ValueObjects;
using System;

namespace OrderEcommerce.Infra.Context.MappingConfiguration
{
    public class AddressMappingConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> addressBuilder)
        {
            addressBuilder.Property<Guid>("Id")
                          .IsRequired();

            addressBuilder.HasKey("Id");
        }
    }
}
