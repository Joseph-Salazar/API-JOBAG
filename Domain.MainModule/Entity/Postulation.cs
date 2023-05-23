using Domain.Core.Entity;

namespace Domain.MainModule.Entity;

public class Postulation : Entity<int>
{
    public bool IsCompleted { get; set; }
    public int JobOfferId { get; set; }
    public JobOffer JobOffer { get; set; }
    public ICollection<Postulant> Postulants { get; set; }
}