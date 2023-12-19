namespace Application.Abstractions.Messaging;

using Domain.Shared;
using MediatR;
public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
