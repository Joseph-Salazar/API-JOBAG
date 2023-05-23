using Domain.MainModule.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.MainModule.EntityConfig;

public class PostulationConfig : IEntityTypeConfiguration<Postulation>
{
    public void Configure(EntityTypeBuilder<Postulation> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.JobOffer)
            .WithMany(f => f.Postulations);

        builder.HasMany(e => e.Postulants)
            .WithMany(f => f.Postulations);
    }
}