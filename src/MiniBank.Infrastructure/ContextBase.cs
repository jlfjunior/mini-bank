using Microsoft.EntityFrameworkCore;

namespace MiniBank.Infrastructure
{
    public abstract class ContextBase : DbContext
    {
        protected ContextBase(DbContextOptions options) : base(options)
        {
        }
    }
}
