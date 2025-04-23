using Domain.DatabaseEntities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreSQLServer.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(b => b.Id);

            builder
                .Property(e => e.Id)
                .HasConversion(id => id.Value, value
            => new IdGuid(value));

            builder.HasOne(e => e.ApplicationUser)
                .WithMany(e => e.Categories)
                .HasForeignKey(f => f.UserId);
        }
    }
}
