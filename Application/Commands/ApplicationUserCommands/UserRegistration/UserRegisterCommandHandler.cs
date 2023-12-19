using Application.Abstractions.Messaging;
using Domain.Shared;
using Infrastructure.UnitOfWork;

namespace Application.Commands.ApplicationUserCommands.UserRegistration;

public sealed class UserRegisterCommandHandler(IUnitOfWork unitOfWork) :
    ICommandHandler<UserRegisterCommand>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public Task<Result> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
