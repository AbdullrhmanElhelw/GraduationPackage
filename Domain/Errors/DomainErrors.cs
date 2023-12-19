using Domain.Shared;
namespace Domain.Errors;

public static class DomainErrors
{
    public static class PatientErrors
    {
        public static Error NotFound(int id) => new(nameof(NotFound), $"Patient with id {id} not found.");
    }
}
