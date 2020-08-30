using System.Threading.Tasks;
using MediatR;
using PL.BuildingBlocks.Application;
using PL.BuildingBlocks.Application.Processing;

namespace PL.Authorization.Infrastructure.Processing
{
    internal class QueryBus : IQueryBus
    {
        private readonly IMediator _mediator;

        public QueryBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query)
        {
            return await _mediator.Send(query);
        }
    }
}