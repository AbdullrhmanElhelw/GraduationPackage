using Application.Abstractions.Messaging;
namespace Application.Commands.ApplicationUserCommands.UserRegistration;

public record UserRegisterCommand(string FristName, string LastName, string SSN, string Email, string Password, string ConfirmPassword) :
    ICommand;
