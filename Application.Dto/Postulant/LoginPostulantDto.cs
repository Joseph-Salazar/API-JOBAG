using System.ComponentModel.DataAnnotations;

namespace Application.Dto.Postulant;

public class LoginPostulantDto
{
    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
}