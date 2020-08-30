using System.Text;
using PL.BuildingBlocks.Application;
using PL.BuildingBlocks.Application.Processing;

namespace PL.Authorization.Application.Authentication
{
    public class AuthenticateCommand : ICommand<AuthenticationResult>
    {
        public string Password { get; }
        public string Login { get; }

        public AuthenticateCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
