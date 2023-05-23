using Application.Dto.SavedJobOffer;

namespace Application.MainModule.Interface;

public interface ISavedJobOffersAppService
{
    Task<SavedJobOffersDto> GetById(int savedJobOfferId);
    Task<string> Add(AddSavedJobOffersDto savedJobOfferDto);
    Task<string> Update(SavedJobOffersDto updateSavedJobOfferDto);
}