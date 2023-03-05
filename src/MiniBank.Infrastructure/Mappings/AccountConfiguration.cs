using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniBank.Domain.Entities;

namespace MiniBank.Infrastructure.Mappings
{
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.UserId)
                .IsRequired();

            builder.Property(x => x.Description);
            builder.Property(x => x.Balance);
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.UpdatedAt);
        }
    }
}
