namespace Application.Dto.JobOffer;

public class AddJobOfferDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public double Wage { get; set; }
    public bool HasHired { get; set; }
    public int CompanyId { get; set; }
}