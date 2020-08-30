using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PL.Authorization.Application;
using PL.Authorization.Application.UserRegistration;

namespace PL.API.Authorization
{
    [Route("authorization/[controller]")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {
        private readonly IAuthorizationModule _authorizationModule;

        public UserAccountsController(IAuthorizationModule authorizationModule)
        {
            _authorizationModule = authorizationModule;
        }

        [AllowAnonymous]
        [HttpPost("")]
        public async Task<IActionResult> RegisterNewUser(RegisterNewUserRequest request)
        {
            await _authorizationModule.ExecuteCommandAsync(new RegisterNewUserCommand(
                request.Login, 
                request.Password,
                request.Email, 
                request.FirstName, 
                request.LastName));

            return Ok();
        }
    }
}
