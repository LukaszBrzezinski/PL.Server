using System.Threading.Tasks;
using MediatR;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure
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