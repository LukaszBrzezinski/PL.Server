using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PL.BuildingBlocks.Application;

namespace PL.BuildingBlocks.Infrastructure
{
    public interface IMessageBus
    {
        Task ExecuteCommandAsync(ICommand command);
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }
}
