﻿using System.Collections.Generic;
using System.Text;
using PL.BuildingBlocks.Application;
using PL.BuildingBlocks.Application.Processing;

namespace PL.Authorization.Application.UserRegistration
{
    public class RegisterNewUserCommand : ICommand
    {
        public string Login { get; }

        public string Password { get; }

        public string Email { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public RegisterNewUserCommand(string login, string password, string email, string firstName, string lastName)
        {
            Login = login;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
