using Domain.DatabaseEntities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreSQLServer.Configuration
{
    internal class BudgetItemConfiguration : IEntityTypeConfiguration<BudgetItem>
    {
        public void Configure(EntityTypeBuilder<BudgetItem> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .Property(e => e.Id)
                .HasConversion(id => id.Value, value
            => new IdGuid(value));

            builder.Property(p => p.Amount)
                .HasColumnType("decimal(18, 2)");

            builder.HasOne(e => e.ApplicationUser)
                .WithMany(e => e.BudgetItems)
                .HasForeignKey(f => f.UserId);
        }
    }
}
