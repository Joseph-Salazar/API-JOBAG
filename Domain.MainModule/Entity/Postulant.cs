using Domain.Core.Entity;

namespace Domain.MainModule.Entity;

public class Postulant : Entity<int>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public double Salary { get; set; } = 0;
    public string Email { get; set; } = string.Empty;
    public int PhoneNumber { get; set; } = 0;
    public string ProfilePicture { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int? RoleId { get; set; }
    public Role PostulantRole { get; set; }
    public ICollection<Postulation> Postulations { get; set; }
    public ICollection<SavedJobOffers> SavedJobOffers { get; set; }

}