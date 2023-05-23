using Application.Core;
using Application.Dto.Postulant;
using Application.Dto.Postulation;
using Application.MainModule.Interface;
using AutoMapper.QueryableExtensions;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Domain.MainModule.Validations.PostulantValidations;
using Domain.MainModule.Validations.PostulationValidations;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.CustomExections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.MainModule;

public class PostulationAppService : BaseAppService, IPostulationAppService
{
    private readonly IPostulationRepository _postulationRepository;

    public PostulationAppService(
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _postulationRepository = serviceProvider.GetService<IPostulationRepository>() ??
                                 throw new InvalidOperationException();
    }

    public async Task<PostulationDto> GetById(int postulationId)
    {
        if (postulationId == 0)
            throw new WarningException(MessageConst.InvalidSelection);

        var postulationDto = await _postulationRepository
            .Find(p => p.Id == postulationId)
            .ProjectTo<PostulationDto>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        if (postulationDto is null)
            throw new WarningException(MessageConst.InvalidSelection);

        return postulationDto;
    }

    public async Task<string> Add(AddPostulationDto postulantDto)
    {
        var newPostulation = Mapper.Map<Postulation>(postulantDto);
        await _postulationRepository.AddAsync(newPostulation, new AddPostulationValidator(_postulationRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Update(PostulationDto postulationDto)
    {
        var postulationDomain = await _postulationRepository.GetAsync(postulationDto.Id);

        if (postulationDomain is null)
            throw new WarningException(MessageConst.InvalidSelection);

        Mapper.Map(postulationDto, postulationDomain);

        await _postulationRepository.UpdateAsync(postulationDomain,
            new AddPostulationValidator(_postulationRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }
}