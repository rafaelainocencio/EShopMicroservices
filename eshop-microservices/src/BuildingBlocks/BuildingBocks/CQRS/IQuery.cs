using MediatR;

namespace BuildingBocks.CQRS
{
    internal interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {

    }
}
