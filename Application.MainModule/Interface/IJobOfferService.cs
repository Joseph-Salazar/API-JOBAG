using Application.Dto.JobLabel;
using Application.Dto.JobOffer;

namespace Application.MainModule.Interface;

public interface IJobOfferService
{
    Task<JobOfferDto> GetById(int jobOfferId);
    Task<string> Add(AddJobOfferDto jobOfferDto);
    Task<string> Update(JobOfferDto updateJobOfferDto);
}