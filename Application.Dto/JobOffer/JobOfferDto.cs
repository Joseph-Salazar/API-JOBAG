namespace Application.Dto.JobOffer;

public class JobOfferDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Wage { get; set; }
    public bool HasHired { get; set; }
    public int CompanyId { get; set; }
}