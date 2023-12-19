using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(p => p.FirstName).HasMinLength(3).HasMaxLength(30).IsRequired();
        builder.Property(p => p.Address).HasMaxLength(100).IsRequired();
        builder.Property(p => p.SSN).HasMinLength(14).HasMaxLength(14).IsRequired();
        builder.Property(p => p.LastName).HasMinLength(3).HasMaxLength(40);
        builder.Property(p => p.City).HasMaxLength(50).IsRequired();
        builder.HasIndex(p => p.SSN).IsUnique();
    }
}
