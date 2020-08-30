using MediatR;

namespace PL.BuildingBlocks.Application.Processing
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}