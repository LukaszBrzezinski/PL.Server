﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PL.Authorization.Infrastructure.Models;
using PL.BuildingBlocks.Application;

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

    public class RegisterNewUserCommandHandler : ICommandHandler<RegisterNewUserCommand>
    {
        public Task<Unit> Handle(RegisterNewUserCommand request, CancellationToken cancellationToken)
        {
            if (!CanRegisterUser()) throw new NotImplementedException();
            var password = PasswordManager.HashPassword(request.Password);

            var user = User.Create(
                request.Login,
                password,
                request.Email,
                request.FirstName,
                request.LastName);


        }

        private bool CanRegisterUser()
        {
            throw new NotImplementedException();
        }
    }
}
