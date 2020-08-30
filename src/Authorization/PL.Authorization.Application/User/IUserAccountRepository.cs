using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PL.Authorization.Application.User
{
    public interface IUserAccountRepository
    {
        Task AddAsync(UserAccount userAccount);
    }
}
