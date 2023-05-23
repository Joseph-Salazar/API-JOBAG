using Application.Core;
using Application.Dto.JobLabel;
using Application.Dto.JobOffer;
using Application.MainModule.Interface;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Domain.MainModule.Validations.CompanyValidations;
using Domain.MainModule.Validations.JobLabelValidations;
using Domain.MainModule.Validations.JobOfferValidations;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.CustomExections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.MainModule;

public class JobOfferAppService : BaseAppService, IJobOfferService
{
    private readonly IJobOfferRepository _jobOfferRepository;

    public JobOfferAppService(
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _jobOfferRepository = serviceProvider.GetService<IJobOfferRepository>() ?? throw new InvalidOperationException();
    }

    public async Task<JobOfferDto> GetById(int jobOfferId)
    {
        if (jobOfferId == 0)
            throw new WarningException(MessageConst.InvalidSelection);

        var jobOfferDto = await _jobOfferRepository
            .Find(p => p.Id == jobOfferId)
            .ProjectTo<JobOfferDto>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        if (jobOfferDto is null)
            throw new WarningException(MessageConst.InvalidSelection);

        return jobOfferDto;
    }

    public async Task<string> Add(AddJobOfferDto jobOfferDto)
    {
        var newCompany = Mapper.Map<JobOffer>(jobOfferDto);
        await _jobOfferRepository.AddAsync(newCompany, new AddJobOfferValidator(_jobOfferRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Update(JobOfferDto jobOfferDto)
    {
        var jobLabelDomain = await _jobOfferRepository.GetAsync(jobOfferDto.Id);

        if (jobLabelDomain is null)
            throw new WarningException(MessageConst.InvalidSelection);

        Mapper.Map(jobOfferDto, jobLabelDomain);

        await _jobOfferRepository.UpdateAsync(jobLabelDomain, new AddJobOfferValidator(_jobOfferRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }
}