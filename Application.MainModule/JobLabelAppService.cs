using Application.Core;
using Application.Dto.Company;
using Application.Dto.JobLabel;
using Application.MainModule.Interface;
using AutoMapper.QueryableExtensions;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Domain.MainModule.Validations.CompanyValidations;
using Domain.MainModule.Validations.JobLabelValidations;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.CustomExections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.MainModule;

public class JobLabelAppService : BaseAppService, IJobLabelService
{
    private readonly IJobLabelRepository _jobLabelRepository;

    public JobLabelAppService(
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _jobLabelRepository= serviceProvider.GetService<IJobLabelRepository>() ?? throw new InvalidOperationException();
    }

    public async Task<JobLabelDto> GetById(int jobLabelId)
    {
        if (jobLabelId == 0)
            throw new WarningException(MessageConst.InvalidSelection);

        var companyDto = await _jobLabelRepository
            .Find(p => p.Id == jobLabelId)
            .ProjectTo<JobLabelDto>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        if (companyDto is null)
            throw new WarningException(MessageConst.InvalidSelection);

        return companyDto;
    }

    public async Task<string> Add(AddJobLabelDto jobLabelDto)
    {
        var newCompany = Mapper.Map<JobLabel>(jobLabelDto);
        await _jobLabelRepository.AddAsync(newCompany, new AddJobLabelValidator(_jobLabelRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Update(JobLabelDto jobLabelDto)
    {
        var jobLabelDomain = await _jobLabelRepository.GetAsync(jobLabelDto.Id);

        if (jobLabelDomain is null)
            throw new WarningException(MessageConst.InvalidSelection);

        Mapper.Map(jobLabelDto, jobLabelDomain);

        await _jobLabelRepository.UpdateAsync(jobLabelDomain, new AddJobLabelValidator(_jobLabelRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }
}