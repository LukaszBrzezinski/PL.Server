using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using PL.BuildingBlocks.Application;

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

    public class AuthenticationResult
    {
        public bool IsAuthenticated { get; }
        public string AuthenticationError { get; }
        public UserDto User { get; }

        public AuthenticationResult(string authenticationError)
        {
            IsAuthenticated = false;
            AuthenticationError = authenticationError;
        }

        public AuthenticationResult(UserDto user)
        {
            this.IsAuthenticated = true;
            this.User = user;
        }
    }

    public class UserDto
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Claim> Claims { get; set; }
        public string Password { get; set; }
    }
}
