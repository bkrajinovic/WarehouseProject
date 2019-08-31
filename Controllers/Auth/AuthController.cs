using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Models;
using Warehouse.Requests.Auth;
using Warehouse.Responses;
using Warehouse.Services.Contracts;

namespace Warehouse.Controllers.Auth
{
    [Route("api/auth")]

    public class AuthController : AppController
    {

        private readonly IAuthService AuthService;
        private readonly IUserService UserService;

        public AuthController(
            IAuthService authService,
            IUserService userService
            )
        {
            AuthService = authService;
            UserService = userService;
        }

        [HttpPost("login")]
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
            string token = await AuthService.SignInAsync(request.Email, request.Password);

            if (string.IsNullOrEmpty(token))
                throw new ApplicationException("WRONG_EMAIL_PASSWORD");

            return new LoginResponse()
            {
                Token = token,
                User = new LoginReponseUser()
                {
                    Username = request.Email,
                    Email = request.Email
                }
            };
        }

        [HttpPost("register")]
        public async Task<RegisterResponse> Register([FromBody] RegisterRequest request)
        {
            string token = await AuthService.RegisterAsync(request.Email, request.Password, request.FirstName, request.LastName);
            var user = await UserService.getByEmailAsync(request.Email);

            if (string.IsNullOrEmpty(token))
                throw new ApplicationException("WRONG_EMAIL_PASSWORD");

            return new RegisterResponse
            {
                User = new AuthUserResponse
                {
                    Id = 1,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                },
                Token = token
            };
        }

        [Authorize]
        [HttpGet]
        public object Protected()
        {
            return "Protected area";
        }
    }
}

