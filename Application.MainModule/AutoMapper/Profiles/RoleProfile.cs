using Application.Dto.Role;
using AutoMapper;
using Domain.MainModule.Entity;

namespace Application.MainModule.AutoMapper.Profiles;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<Role, RoleDto>();
        CreateMap<AddRoleDto, Role>().ReverseMap();
    }
}