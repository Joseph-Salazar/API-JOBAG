using Domain.MainModule.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.MainModule.EntityConfig;

public class SavedJobOffersConfig : IEntityTypeConfiguration<SavedJobOffers>
{
    public void Configure(EntityTypeBuilder<SavedJobOffers> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(e => e.Postulants)
            .WithMany(f => f.SavedJobOffers);

        builder.HasMany(e => e.JobOffers)
            .WithMany(f => f.SavedJobOffers);
    }
}