namespace Domain.Entites;

public class Patient
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string SSN { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}
