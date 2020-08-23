using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.API.Authorization
{
    public class AuthorizationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
    }
}
