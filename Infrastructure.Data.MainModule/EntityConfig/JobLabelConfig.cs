using Domain.MainModule.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.MainModule.EntityConfig;

public class JobLabelConfig : IEntityTypeConfiguration<JobLabel>
{
    public void Configure(EntityTypeBuilder<JobLabel> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(e => e.JobOffers)
            .WithMany(f => f.JobLabels);
    }
}