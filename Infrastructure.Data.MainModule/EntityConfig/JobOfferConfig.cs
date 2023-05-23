using Domain.MainModule.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.MainModule.EntityConfig;

public class JobOfferConfig : IEntityTypeConfiguration<JobOffer>
{
    public void Configure(EntityTypeBuilder<JobOffer> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(e => e.JobLabels)
            .WithMany(f => f.JobOffers);

        builder.HasMany(e => e.Postulations)
            .WithOne(f => f.JobOffer);
    }
}