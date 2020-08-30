using System;

namespace PL.Authorization.Application.User
{
    //TODO: consider UserAccountRequest/Draft
    public class UserAccount
    {
        public Guid UserId { get; private set; }

        private string _login;
        private string _password;
        private string _email;
        private bool _isActive;
        private string _firstName;
        private string _lastName;

        private UserAccount(string login, string password, string email, bool isActive, string firstName, string lastName, Guid userId)
        {
            _login = login;
            _password = password;
            _email = email;
            _isActive = isActive;
            _firstName = firstName;
            _lastName = lastName;
            UserId = userId;
        }

        private UserAccount()
        {
            // For ef core
        }

        public static UserAccount Create(string login, string password, string email, string firstName, string lastName)
        {
            var userId = Guid.NewGuid();

            return new UserAccount(
                login, 
                password, 
                email, 
                false, 
                firstName, 
                lastName, 
                userId);
        }
    }
}
