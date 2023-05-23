using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using FluentValidation;

namespace Domain.MainModule.Validations.JobOfferValidations;

public class AddJobOfferValidator : AbstractValidator<JobOffer>
{
    private readonly IJobOfferRepository _jobOfferRepository;

    public AddJobOfferValidator(IJobOfferRepository jobOfferRepository)
    {
        _jobOfferRepository = jobOfferRepository;
    }
}