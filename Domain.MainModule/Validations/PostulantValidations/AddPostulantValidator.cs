using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using FluentValidation;

namespace Domain.MainModule.Validations.PostulantValidations;

public class AddPostulantValidator : AbstractValidator<Postulant>
{
    private readonly IPostulantRepository _postulant;

    public AddPostulantValidator(IPostulantRepository postulant)
    {
        _postulant = postulant;
    }
}