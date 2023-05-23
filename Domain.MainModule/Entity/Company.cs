using Domain.Core.Entity;

namespace Domain.MainModule.Entity;
public class Company : Entity<int>
{
    public string CompanyName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string WebsiteUrl { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public int? RoleId { get; set; }
    public byte[] PasswordHash { get; set; } = new byte[32];
    public byte[] PasswordSalt { get; set; } = new byte[32];
    public string? VerificationToken { get; set; }
    public Role CompanyRole { get; set; }
}