using FluentValidation;

namespace Application.Commands.PatientCommands;

public class CreatePatientCommandValidator : AbstractValidator<CreatePatientCommand>
{
    public CreatePatientCommandValidator()
    {
        RuleFor(p => p.CreatePatient.FirstName)
            .NotEmpty()
            .WithMessage("First name is required")
            .MaximumLength(50)
            .WithMessage("First name must not exceed 50 characters");

        RuleFor(p => p.CreatePatient.FirstName)
            .NotEmpty()
            .WithMessage("Last name is required")
            .MaximumLength(50)
            .WithMessage("Last name must not exceed 50 characters");

        RuleFor(p => p.CreatePatient.FirstName)
            .NotEmpty()
            .WithMessage("Address is required")
            .MaximumLength(100)
            .WithMessage("Address must not exceed 100 characters");

        RuleFor(p => p.CreatePatient.FirstName)
            .NotEmpty()
            .WithMessage("City is required")
            .MaximumLength(50)
            .WithMessage("City must not exceed 50 characters");

        RuleFor(p => p.CreatePatient.SSN)
            .NotEmpty()
            .WithMessage("SSN is required")
            .MaximumLength(14)
            .WithMessage("SSN must not exceed 11 characters")
            .MinimumLength(14)
            .WithMessage("SSN must be at least 11 characters");

    }
}
