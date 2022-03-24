using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValueObjects;

namespace Infrastructure.Mapping
{
    internal class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");

            builder.HasKey(a => a.Id);

            builder
                .Property(n => n.Title)
                .HasConversion(n => n.Value, v => Title.Create(v).Value)
                .HasMaxLength(Title.TitleMaxLength)
                .IsRequired();

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
