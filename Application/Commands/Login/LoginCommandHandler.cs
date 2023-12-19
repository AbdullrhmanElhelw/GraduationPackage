using Application.Abstractions.Messaging;
using Domain.Shared;

namespace Application.Commands.Login;

public sealed class LoginCommandHandler : ICommandHandler<LoginCommand, string>
{
    public Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
