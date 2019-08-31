using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Services.Contracts
{
    public interface IUserService
    {
         Task<AuthUser> getByEmailAsync(string email);
    }
}