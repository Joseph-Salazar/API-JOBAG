using Domain.Core.Entity;

namespace Domain.MainModule.Entity;

public class Role : Entity<int>
{
    public string RoleName { get; set; }
    public ICollection<Company> Companies { get; set; }
    public ICollection<Postulant> Postulants { get; set; }
}