namespace Application.ApplicationServices.DTOs.PatientsDTOs;

public class ReadPatientDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string SSN { get; set; } = string.Empty;
}
