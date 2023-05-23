namespace Application.Dto.Company;

public class AddCompanyDto
{
    public string CompanyName { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
    public string WebsiteUrl { get; set; }
    public string ImageUrl { get; set; }
    public int RoleId { get; set; }
}