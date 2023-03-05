namespace MiniBank.Infrastructure.Repositories
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected readonly Context Context;
        protected readonly ReadOnlyContext ReadOnlyContext;

        public RepositoryBase(Context context, ReadOnlyContext readOnlyContext) 
        { 
            Context = context;
            ReadOnlyContext = readOnlyContext;
        }
    }
}
