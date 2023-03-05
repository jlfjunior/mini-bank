using Microsoft.EntityFrameworkCore;

namespace MiniBank.Infrastructure
{
    public class Context : ContextBase
    {
        public Context(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            ChangeTracker.LazyLoadingEnabled = true;
            ChangeTracker.AutoDetectChangesEnabled = true;
        }
    }
}
