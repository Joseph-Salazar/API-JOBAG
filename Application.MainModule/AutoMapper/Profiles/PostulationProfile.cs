using Application.Dto.Postulation;
using AutoMapper;
using Domain.MainModule.Entity;

namespace Application.MainModule.AutoMapper.Profiles;

public class PostulationProfile : Profile
{
    public PostulationProfile()
    {
        CreateMap<Postulation, PostulationDto>();
        CreateMap<AddPostulationDto, Postulation>().ReverseMap();
    }
}