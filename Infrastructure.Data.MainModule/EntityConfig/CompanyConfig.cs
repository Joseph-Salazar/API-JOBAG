using Domain.Core.Auditory;
using Domain.MainModule.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.MainModule.EntityConfig;

public class CompanyConfig : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.CompanyRole)
            .WithMany(e => e.Companies)
            .HasForeignKey(e => e.RoleId).IsRequired(false);
    }
}