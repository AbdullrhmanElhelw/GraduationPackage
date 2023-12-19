using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

internal class HospitalAdminConfiguration : IEntityTypeConfiguration<HospitalAdmin>
{
    public void Configure(EntityTypeBuilder<HospitalAdmin> builder)
    {
        builder.Property(p => p.HospitalCode).HasMaxLength(10).IsRequired();
    }
}