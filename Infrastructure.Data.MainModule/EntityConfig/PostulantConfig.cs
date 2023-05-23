using Domain.MainModule.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.MainModule.EntityConfig;

public class PostulantConfig : IEntityTypeConfiguration<Postulant>
{
    public void Configure(EntityTypeBuilder<Postulant> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.PostulantRole)
            .WithMany(e => e.Postulants)
            .HasForeignKey(e => e.RoleId)
            .IsRequired(false);

        builder.HasMany(e => e.Postulations)
            .WithMany(f => f.Postulants);

        builder.HasMany(e => e.SavedJobOffers)
            .WithMany(f => f.Postulants);
    }
}