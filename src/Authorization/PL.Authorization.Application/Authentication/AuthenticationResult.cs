namespace PL.Authorization.Application.Authentication
{
    public class AuthenticationResult
    {
        public bool IsAuthenticated { get; }
        public string AuthenticationError { get; }
        public UserDto User { get; }

        public AuthenticationResult(string authenticationError)
        {
            IsAuthenticated = false;
            AuthenticationError = authenticationError;
        }

        public AuthenticationResult(UserDto user)
        {
            this.IsAuthenticated = true;
            this.User = user;
        }
    }
}