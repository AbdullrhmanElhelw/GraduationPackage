namespace Application.ApplicationServices.DTOs.PatientsDTOs;

public record CreatePatientDTO
    (string FirstName, string LastName, string Address, string City, string SSN);
