using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using FluentValidation;

namespace Domain.MainModule.Validations.PostulationValidations;

public class AddPostulationValidator : AbstractValidator<Postulation>
{
    private readonly IPostulationRepository _postulationRepository;

    public AddPostulationValidator(IPostulationRepository postulationRepository)
    {
        _postulationRepository = postulationRepository;
    }
}