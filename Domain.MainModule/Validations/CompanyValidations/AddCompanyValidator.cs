using FluentValidation;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;

namespace Domain.MainModule.Validations.CompanyValidations;

public class AddCompanyValidator : AbstractValidator<Company>
{
    private readonly ICompanyRepository _companyRepository;

    public AddCompanyValidator(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }
}