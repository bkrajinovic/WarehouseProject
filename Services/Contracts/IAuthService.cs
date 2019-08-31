using System.Threading.Tasks;

namespace Warehouse.Services.Contracts
{
    public interface IAuthService
    {
        Task<string> SignInAsync(string email, string password);
        Task<string> RegisterAsync(string email, string password, string firstName, string lastName);
    }
}