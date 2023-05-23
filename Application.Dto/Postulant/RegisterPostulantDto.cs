using System.ComponentModel.DataAnnotations;

namespace Application.Dto.Postulant;

public class RegisterPostulantDto
{
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required, MinLength(4)]
    public string Password { get; set; }
    [Required, Compare("Password")]
    public string ConfirmPassword { get; set; }
}