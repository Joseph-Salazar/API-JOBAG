using Application.Core;
using Application.Dto.Company;
using Application.Dto.JobOffer;
using Application.Dto.Postulant;
using Application.MainModule.Interface;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Domain.MainModule.Validations.JobOfferValidations;
using Domain.MainModule.Validations.PostulantValidations;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.CustomExections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace Application.MainModule;

public class PostulantAppService : BaseAppService, IPostulantAppService
{
    private readonly IPostulantRepository _postulantRepository;

    public PostulantAppService(
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _postulantRepository = serviceProvider.GetService<IPostulantRepository>() ?? throw new InvalidOperationException();
    }

    public async Task<PostulantDto> GetById(int postulantId)
    {
        if (postulantId == 0)
            throw new WarningException(MessageConst.InvalidSelection);

        var postulantDto = await _postulantRepository
            .Find(p => p.Id == postulantId)
            .ProjectTo<PostulantDto>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        if (postulantDto is null)
            throw new WarningException(MessageConst.InvalidSelection);

        return postulantDto;
    }

    public async Task<PostulantDto> GetByEmailAndPassword(string email, string password)
    {
        if (email.IsNullOrEmpty() || password.IsNullOrEmpty())
            throw new WarningException(MessageConst.InvalidSelection);

        var postulantDto = await _postulantRepository
            .Find(p => p.Email == email && p.Password == password)
            .ProjectTo<PostulantDto>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        if (postulantDto is null)
            throw new WarningException(MessageConst.InvalidSelection);

        return postulantDto;
    }

    public async Task<string> Register(RegisterPostulantDto registerPostulantDto)
    {
        var newPostulant = Mapper.Map<Postulant>(registerPostulantDto);
        await _postulantRepository.AddAsync(newPostulant, new AddPostulantValidator(_postulantRepository));
        await UnitOfWork.SaveChangesAsync();
        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Add(AddPostulantDto postulantDto)
    {
        var newPostulant = Mapper.Map<Postulant>(postulantDto);
        await _postulantRepository.AddAsync(newPostulant, new AddPostulantValidator(_postulantRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Update(PostulantDto postulantDto)
    {
        var postulantDomain = await _postulantRepository.GetAsync(postulantDto.Id);

        if (postulantDomain is null)
            throw new WarningException(MessageConst.InvalidSelection);

        Mapper.Map(postulantDto, postulantDomain);

        await _postulantRepository.UpdateAsync(postulantDomain, new AddPostulantValidator(_postulantRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }
}