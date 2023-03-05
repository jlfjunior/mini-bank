using MiniBank.Domain.Entities;
using System.Threading.Tasks;

namespace MiniBank.Domain.Repositories
{
    public interface IAccountRepository
    {
        Task CreateAccountAsync(Account account);
    }
}
