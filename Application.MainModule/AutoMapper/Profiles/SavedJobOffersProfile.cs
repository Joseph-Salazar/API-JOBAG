using Application.Dto.SavedJobOffer;
using AutoMapper;
using Domain.MainModule.Entity;

namespace Application.MainModule.AutoMapper.Profiles;

public class SavedJobOffersProfile : Profile
{
    public SavedJobOffersProfile()
    {
        CreateMap<SavedJobOffers, SavedJobOffersDto>();
        CreateMap<AddSavedJobOffersDto, SavedJobOffers>().ReverseMap();
    }
}