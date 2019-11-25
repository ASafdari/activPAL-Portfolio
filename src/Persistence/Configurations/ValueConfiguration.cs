using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Entities;

namespace Persistence.Configurations
{
    public class ValueConfiguration : IEntityTypeConfiguration<Value>
    {
        public void Configure(EntityTypeBuilder<Value> builder)
        {
            builder.Property(v => v.MyValue)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}