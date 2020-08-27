using System;
using System.Collections.Generic;
using System.Text;

namespace PL.Authorization.Infrastructure.Models
{
    public class User
    {
        public Guid UserId { get; private set; }

        private string _login;
        private string _password;
        private string _email;
        private bool _isActive;
        private string _firstName;
        private string _lastName;
    }
}
