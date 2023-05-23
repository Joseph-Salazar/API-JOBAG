using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Application.Dto.Company;

public class LoginCompanyDto
{
    [Required, EmailAddress] 
    public string Email { get; set; } = string.Empty;
    [Required] public string Password { get; set; } = string.Empty;
}