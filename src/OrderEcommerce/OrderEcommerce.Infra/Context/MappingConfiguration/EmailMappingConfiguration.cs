using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderEcommerce.Domain.ValueObjects;
using System;

namespace OrderEcommerce.Infra.Context.MappingConfiguration
{
    public class EmailMappingConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> emailBuilder)
        {
            emailBuilder.Property<Guid>("Id")
                .IsRequired();

            emailBuilder.HasKey("Id");
        }
    }
}
