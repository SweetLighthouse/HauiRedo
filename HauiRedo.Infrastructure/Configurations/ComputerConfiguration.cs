using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using HauiRedo.Domain.Entities;

namespace HauiRedo.Infrastructure.Configurations;

internal class ComputerConfiguration : IEntityTypeConfiguration<Computer>
{
    public void Configure(EntityTypeBuilder<Computer> builder)
    {
        builder.ToTable(nameof(Computer));
        builder.HasKey(item => item.Id);
        builder.Property(item => item.Id).ValueGeneratedOnAdd();
    }
}
