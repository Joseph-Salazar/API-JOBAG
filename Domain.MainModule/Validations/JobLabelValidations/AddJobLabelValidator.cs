using Domain.MainModule.IRepository;
using Domain.MainModule.Entity;
using FluentValidation;

namespace Domain.MainModule.Validations.JobLabelValidations;

public class AddJobLabelValidator : AbstractValidator<JobLabel>
{
    private readonly IJobLabelRepository _jobLabelRepository;

    public AddJobLabelValidator(IJobLabelRepository jobLabelRepository)
    {
        _jobLabelRepository = jobLabelRepository;
    }
}