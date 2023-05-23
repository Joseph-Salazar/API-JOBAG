using Domain.Core.Entity;

namespace Domain.MainModule.Entity;

public class JobLabel : Entity<int>
{
    public string Label { get; set; }
    public ICollection<JobOffer> JobOffers { get; set; }
}