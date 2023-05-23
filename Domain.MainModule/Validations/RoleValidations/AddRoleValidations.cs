using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using FluentValidation;

namespace Domain.MainModule.Validations.RoleValidations;

public class AddRoleValidations : AbstractValidator<Role>
{
    private readonly IRoleRepository _roleRepository;

    public AddRoleValidations(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
}