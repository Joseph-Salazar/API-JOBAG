using Application.Dto.Company;
using Application.Dto.Postulant;

namespace Application.MainModule.Interface;

public interface IPostulantAppService
{
    Task<PostulantDto> GetById(int postulantId);
    Task<string> Add(AddPostulantDto postulantDto);
    Task<string> Update(PostulantDto updaPostulantDto);
    Task<PostulantDto> GetByEmailAndPassword(string email, string password);
    Task<string> Register(RegisterPostulantDto registerPostulantDto);
}