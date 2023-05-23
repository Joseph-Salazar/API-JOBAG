using Application.Dto.Role;

namespace Application.MainModule.Interface;

public interface IRoleAppService
{
    Task<RoleDto> GetById(int roleId);
    Task<string> Add(AddRoleDto roleDto);
    Task<string> Update(RoleDto updateRoleDto);
}