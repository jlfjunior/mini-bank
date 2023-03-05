using Microsoft.EntityFrameworkCore;

namespace MiniBank.Infrastructure
{
    public class ReadOnlyContext : ContextBase
    {
        public ReadOnlyContext(DbContextOptions<ReadOnlyContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
