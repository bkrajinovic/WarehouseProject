using Microsoft.AspNetCore.Identity;

namespace Warehouse.Responses
{
    public class RegisterResponse : AppResponse
    {
        public string Token { get; set; }
        public AuthUserResponse User { get; set; }
    }
}