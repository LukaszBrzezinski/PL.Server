using MediatR;

namespace PL.BuildingBlocks.Application.Processing
{
    public interface ICommand : IRequest
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {

    }
}
