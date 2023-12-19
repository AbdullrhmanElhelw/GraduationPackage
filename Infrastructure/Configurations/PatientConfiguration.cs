using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

internal class PatientConfiguration : IEntityTypeConfiguration<Patient>
{

    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
        builder.Property(p => p.City).HasMaxLength(50).IsRequired();
        builder.Property(p => p.SSN).HasMaxLength(14).IsFixedLength().IsRequired();
        builder.IsUnique(e => e.SSN);
    }
}
