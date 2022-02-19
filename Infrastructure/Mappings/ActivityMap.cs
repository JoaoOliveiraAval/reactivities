using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping
{
    internal class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.Description);

            builder.Property(a => a.Dates)
                .IsRequired();

            builder.Property(a => a.Category)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.City);
            builder.Property(a => a.Avenue);
        }
    }
}
