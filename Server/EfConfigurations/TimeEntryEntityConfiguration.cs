using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stroom.Shared.Models;


namespace Stroom.Server.EfConfigurations
{
    public class TimeEntryEntityConfiguration : IEntityTypeConfiguration<TimeEntry>
    {
        public void Configure(EntityTypeBuilder<TimeEntry> builder)
        {
            builder.ToTable("TimeEntry");
            builder.HasKey(e => e.TimeEntryID).HasName("TimeEntry_PK");
            //builder.HasKey(e => new { e.TaskID, e.UserID }).HasName("TimeEntry_PK");
            builder.Property(e => e.Hours).IsRequired();
            builder.Property(e => e.Date).IsRequired().HasColumnType("datetime");

            builder.HasOne(e => e.User).WithMany(user => user.TimeEntries).HasForeignKey(e => e.UserID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Task).WithMany(task => task.TimeEntries).HasForeignKey(e => e.TaskID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
