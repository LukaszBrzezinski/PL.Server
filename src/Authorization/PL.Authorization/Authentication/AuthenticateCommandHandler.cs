using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using PL.Authorization.Application.Configurations;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Application.Authentication
{
    internal class AuthenticateCommandHandler : ICommandHandler<AuthenticateCommand, AuthenticationResult>
    {
        private readonly ISqlConnectionFactory _connectionFactory;

        public AuthenticateCommandHandler(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<AuthenticationResult> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var connection = _connectionFactory.GetOpenConnection();

            const string sql = "SELECT " +
                               "[UserAccount].[Id], " +
                               "[UserAccount].[Login], " +
                               "[UserAccount].[Name], " +
                               "[UserAccount].[Email], " +
                               "[UserAccount].[IsActive], " +
                               "[UserAccount].[Password] " +
                               "FROM [auth].[UserAccounts] AS [UserAccount] " +
                               "WHERE [User].[Login] = @Login";

            var user = await connection.QuerySingleOrDefaultAsync<UserDto>(sql, new { request.Login });

            if (user == null)
            {
                return new AuthenticationResult("Incorrect login or password");
            }

            if (!user.IsActive)
            {
                return new AuthenticationResult("User is not active");
            }

            if (!PasswordManager.VerifyHashedPassword(user.Password, request.Password))
            {
                return new AuthenticationResult("Incorrect login or password");
            }

            user.Claims = new List<Claim>();

            return new AuthenticationResult(user);
        }
    }
}