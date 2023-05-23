using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Application.Dto.Company;

public class RegisterCompanyDto
{
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required, MinLength(4)]
    public string Password { get; set; }
    [Required, Compare("Password")]
    public string ConfirmPassword { get; set; }
}