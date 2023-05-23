using Application.Dto.JobLabel;
using AutoMapper;
using Domain.MainModule.Entity;

namespace Application.MainModule.AutoMapper.Profiles;

public class JobLabelProfile : Profile
{
    public JobLabelProfile()
    {
        CreateMap<JobLabel, JobLabelDto>();
        CreateMap<JobLabel, AddJobLabelDto>().ReverseMap();

    }
}