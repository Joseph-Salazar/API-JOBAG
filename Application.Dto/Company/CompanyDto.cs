namespace Application.Dto.Company;

public class CompanyDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Description { get; set; }
    public string WebsiteUrl { get; set; }
    public string ImageUrl { get; set; }
    public int? RoleId { get; set; }
}