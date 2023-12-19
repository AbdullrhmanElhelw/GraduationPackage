using Application.Abstractions.Messaging;

namespace Application.Commands.Login;

public sealed record LoginCommand(LoginRequest Request) : ICommand<string>;