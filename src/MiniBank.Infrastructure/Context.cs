using Microsoft.EntityFrameworkCore;
using System.Reflection;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
