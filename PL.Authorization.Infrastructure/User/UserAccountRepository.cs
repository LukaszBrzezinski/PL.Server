using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PL.API.Authorization;
using PL.Authorization.Application.User;

namespace PL.Authorization.Infrastructure.User
{
    internal class UserAccountRepository : IUserAccountRepository
    {
        private readonly AuthorizationDbContext _context;

        public UserAccountRepository(AuthorizationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(UserAccount userAccount)
        {
            await _context.AddAsync(userAccount);
        }
    }
}
