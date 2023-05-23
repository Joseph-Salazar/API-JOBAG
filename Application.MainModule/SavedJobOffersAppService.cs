using Application.Core;
using Application.Dto.Postulation;
using Application.Dto.SavedJobOffer;
using Application.MainModule.Interface;
using AutoMapper.QueryableExtensions;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Domain.MainModule.Validations.PostulationValidations;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.CustomExections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.MainModule;

//public class SavedJobOffersAppService : BaseAppService, ISavedJobOffersAppService
//{
//    private readonly ISavedJobOfferRepository _savedJobOfferRepository;
//
//    public SavedJobOffersAppService(
//        IServiceProvider serviceProvider) : base(serviceProvider)
//    {
//        _savedJobOfferRepository = serviceProvider.GetService<ISavedJobOfferRepository>() ??
//                                 throw new InvalidOperationException();
//    }
//
//    public async Task<SavedJobOffersDto> GetById(int savedId)
//    {
//        if (savedId == 0)
//            throw new WarningException(MessageConst.InvalidSelection);
//
//        var savedDto = await _savedJobOfferRepository
//            .Find(p => p.Id == savedId)
//            .ProjectTo<SavedJobOffersDto>(Mapper.ConfigurationProvider)
//            .FirstOrDefaultAsync();
//
//        if (savedDto is null)
//            throw new WarningException(MessageConst.InvalidSelection);
//
//        return savedDto;
//    }
//
//    public async Task<string> Add(SavedJobOffersDto savedDto)
//    {
//        var newPostulation = Mapper.Map<Postulation>(savedDto);
//        await _savedJobOfferRepository.AddAsync(newPostulation, new AddS(_postulationRepository));
//        await UnitOfWork.SaveChangesAsync();
//
//        return MessageConst.ProcessSuccessfullyCompleted;
//    }
//
//    public async Task<string> Update(PostulationDto postulationDto)
//    {
//        var postulationDomain = await _postulationRepository.GetAsync(postulationDto.Id);
//
//        if (postulationDomain is null)
//            throw new WarningException(MessageConst.InvalidSelection);
//
//        Mapper.Map(postulationDto, postulationDomain);
//
//        await _postulationRepository.UpdateAsync(postulationDomain,
//            new AddPostulationValidator(_postulationRepository));
//        await UnitOfWork.SaveChangesAsync();
//
//        return MessageConst.ProcessSuccessfullyCompleted;
//    }
//}