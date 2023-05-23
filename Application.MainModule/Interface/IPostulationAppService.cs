using Application.Dto.Postulation;

namespace Application.MainModule.Interface;

public interface IPostulationAppService
{
    Task<PostulationDto> GetById(int postulationId);
    Task<string> Add(AddPostulationDto postulationDto);
    Task<string> Update(PostulationDto updatePostulationDto);
}