using System.Threading;
using System.Threading.Tasks;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Application.Authentication
{
    internal class AuthenticateCommandHandler : ICommandHandler<AuthenticateCommand, AuthenticationResult>
    {
        public Task<AuthenticationResult> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}