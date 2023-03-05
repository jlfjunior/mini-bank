using MiniBank.Domain.Entities;
using MiniBank.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace MiniBank.Infrastructure.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {

        public AccountRepository(Context context, ReadOnlyContext readOnlyContext) 
            : base(context, readOnlyContext)
        { }

        public Task CreateAccountAsync(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
