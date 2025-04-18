using Domain.Entities;
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

            builder
                .Property(e => e.DateCreated)
                .HasConversion(e => e.Value, val => DateCreated.Create().Value);

            builder
                .Property(e => e.Amount)
                .HasConversion(e => e.Value, val => new Currency(val));

            builder
                .Property(e => e.Date)
                .HasConversion(e => e.Value, val => new ItemDate(val));

            builder.HasOne(e => e.CreatedBy)
                .WithMany(e => e.BudgetItems)
                .HasForeignKey(e => e.CreatedBy);
        }
    }
}
