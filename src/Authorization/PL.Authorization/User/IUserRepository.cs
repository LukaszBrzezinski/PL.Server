using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PL.Authorization.Application.User
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}
