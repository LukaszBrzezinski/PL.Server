using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using PL.Authorization.Application.Authentication;

namespace PL.Authorization.Application.Configurations
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly IAuthorizationModule _authorizationModule;

        public ResourceOwnerPasswordValidator(IAuthorizationModule authorizationModule)
        {
            _authorizationModule = authorizationModule;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var authenticationResult = await _authorizationModule.ExecuteCommandAsync(
                new AuthenticateCommand(context.UserName, context.Password));

            if (!authenticationResult.IsAuthenticated)
            {
                context.Result = new GrantValidationResult(
                    TokenRequestErrors.InvalidGrant,
                    authenticationResult.AuthenticationError);

                return;
            }

            context.Result = new GrantValidationResult(
                authenticationResult.User.UserId.ToString(),
                "forms",
                authenticationResult.User.Claims);
        }
    }
}
