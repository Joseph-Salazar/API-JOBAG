using Application.Dto.Company;

namespace Application.MainModule.Interface;

public interface ICompanyAppService
{
    Task<CompanyDto> GetById(int companyId);
    Task<string> Add(AddCompanyDto companyDto);
    Task<string> Update(CompanyDto updateCompanyDto);
    Task<string> Register(RegisterCompanyDto register);
    Task<string> Login(LoginCompanyDto login);

}
