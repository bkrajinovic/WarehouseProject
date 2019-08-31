using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Warehouse.Models;
using Warehouse.Services.Contracts;

namespace Warehouse.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly WarehouseContext Context;

        public UserService(WarehouseContext context)
        {
            Context = context;
        }

        public async Task<AuthUser> getByEmailAsync(string email)
        {
            return await Context.Users
                .Where(u => u.Email == email)
                .Select(u => new AuthUser {
                    Id = u.Id,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName
                }).FirstAsync();
        }
    }
}