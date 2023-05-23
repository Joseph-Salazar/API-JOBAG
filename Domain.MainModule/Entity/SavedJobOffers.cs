using Domain.Core.Entity;

namespace Domain.MainModule.Entity;

public class SavedJobOffers : Entity<int>
{
    public ICollection<JobOffer> JobOffers { get; set; }
    public ICollection<Postulant> Postulants { get; set; }
}