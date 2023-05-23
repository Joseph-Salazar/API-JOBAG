using Application.Core;
using Application.Dto.Postulation;
using Application.Dto.Role;
using Application.MainModule.Interface;
using AutoMapper.QueryableExtensions;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Domain.MainModule.Validations.PostulationValidations;
using Domain.MainModule.Validations.RoleValidations;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.CustomExections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.MainModule;

public class RoleAppService : BaseAppService, IRoleAppService
{
    private readonly IRoleRepository _roleRepository;

    public RoleAppService(
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _roleRepository = serviceProvider.GetService<IRoleRepository>() ??
                                 throw new InvalidOperationException();
    }

    public async Task<RoleDto> GetById(int roleId)
    {
        if (roleId == 0)
            throw new WarningException(MessageConst.InvalidSelection);

        var roleDto = await _roleRepository
            .Find(p => p.Id == roleId)
            .ProjectTo<RoleDto>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        if (roleDto is null)
            throw new WarningException(MessageConst.InvalidSelection);

        return roleDto;
    }

    public async Task<string> Add(AddRoleDto roleDto)
    {
        var newRole = Mapper.Map<Role>(roleDto);
        await _roleRepository.AddAsync(newRole, new AddRoleValidations(_roleRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Update(RoleDto roleDto)
    {
        var roleDomain = await _roleRepository.GetAsync(roleDto.Id);

        if (roleDomain is null)
            throw new WarningException(MessageConst.InvalidSelection);

        Mapper.Map(roleDto, roleDomain);

        await _roleRepository.UpdateAsync(roleDomain, new AddRoleValidations(_roleRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }
}