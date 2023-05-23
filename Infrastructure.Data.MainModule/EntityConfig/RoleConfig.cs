using Domain.MainModule.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.MainModule.EntityConfig;

public class RoleConfig : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(e => e.Postulants)
            .WithOne(f => f.PostulantRole);

        builder.HasMany(e => e.Companies)
            .WithOne(f => f.CompanyRole);
    }
}