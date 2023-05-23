namespace Application.Dto.Postulant;

public class AddPostulantDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public string ProfilePicture { get; set; }
    public int RoleId { get; set; }
}