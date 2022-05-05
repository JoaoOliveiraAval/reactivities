using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValueObjects;

namespace Persistence.Mapping
{
    internal class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");
            builder.HasKey(a => a.Id);
            //builder.Property(n => n.Title)
            //    .HasConversion(n => n.Value, v => Title.Create(v).Value)
            //    .HasMaxLength(Title.TitleMaxLength);
            builder.Property(a => a.Description);
            builder.Property(a => a.Dates);
            builder.Property(a => a.Category).HasMaxLength(100);
            builder.Property(a => a.City);
            builder.Property(a => a.Avenue);
        }
    }
}
