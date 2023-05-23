using Application.Dto.Company;
using AutoMapper;
using Domain.MainModule.Entity;

namespace Application.MainModule.AutoMapper.Profiles;

public class CompanyProfile : Profile
{
    public CompanyProfile()
    {
        CreateMap<Company, CompanyDto>().ReverseMap();
        CreateMap<Company, AddCompanyDto>().ReverseMap();

    }
}