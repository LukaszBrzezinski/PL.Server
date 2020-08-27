using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PL.Authorization.Application.User;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Application.UserRegistration
{
    public class RegisterNewUserCommandHandler : ICommandHandler<RegisterNewUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public RegisterNewUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(RegisterNewUserCommand request, CancellationToken cancellationToken)
        {
            if (!CanRegisterUser()) throw new NotImplementedException();
            var password = PasswordManager.HashPassword(request.Password);

            var user = User.User.Create(
                request.Login,
                password,
                request.Email,
                request.FirstName,
                request.LastName);

            await _userRepository.AddAsync(user);

            return default;
        }

        private bool CanRegisterUser()
        {
            throw new NotImplementedException();
        }
    }
}