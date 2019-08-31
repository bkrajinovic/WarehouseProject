using Warehouse.Models;

namespace Warehouse.Responses
{
    public class LoginReponseUser
    {
        public string Email { get; set; }
        public string Username { get; set; }
    }

    public class LoginResponse : AppResponse
    {
        public string Token { get; set; }

        public LoginReponseUser User { get; set; }
    }
}