using Application.Dto.Postulant;
using AutoMapper;
using Domain.MainModule.Entity;

namespace Application.MainModule.AutoMapper.Profiles;

public class PostulantProfile : Profile
{
    public PostulantProfile()
    {
        CreateMap<Postulant, PostulantDto>();
        CreateMap<AddPostulantDto, Postulant>().ReverseMap();
        CreateMap<RegisterPostulantDto, Postulant>()
            .ReverseMap();
        CreateMap<LoginPostulantDto, Postulant>().ReverseMap();
    }
}