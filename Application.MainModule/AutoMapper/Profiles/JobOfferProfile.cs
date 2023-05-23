using Application.Dto.JobLabel;
using Application.Dto.JobOffer;
using AutoMapper;
using Domain.MainModule.Entity;

namespace Application.MainModule.AutoMapper.Profiles;

public class JobOfferProfile : Profile
{
    public JobOfferProfile()
    {
        CreateMap<JobOffer, JobOfferDto>();
        CreateMap<JobOffer, AddJobOfferDto>().ReverseMap();

    }
}