using MiniBank.Domain.Entities;
using MiniBank.Domain.Repositories;
using System.Threading.Tasks;

namespace MiniBank.Infrastructure.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {

        public AccountRepository(Context context, ReadOnlyContext readOnlyContext) 
            : base(context, readOnlyContext)
        { }

        public async Task CreateAccountAsync(Account account)
        {
            Context.Add(account);

            await Context.SaveChangesAsync();
        }
    }
}
