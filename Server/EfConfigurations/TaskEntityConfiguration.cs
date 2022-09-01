using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stroom.Shared.Models;

namespace Stroom.Server.EfConfigurations
{
    public class TaskEntityConfiguration : IEntityTypeConfiguration<TaskDto>
    {
        public void Configure(EntityTypeBuilder<TaskDto> builder)
        {
            builder.ToTable("Task");
            builder.HasKey(e => e.TaskID).HasName("Task_PK");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Description).HasMaxLength(2048);
            builder.Property(e => e.Priority).IsRequired();
            builder.Property(e => e.Status).IsRequired();
            builder.Property(e => e.EstimatedTime);
            builder.Property(e => e.SubmitionDate);
            builder.Property(e => e.DueDate).HasColumnType("datetime");


            builder.HasOne(e => e.Assignee).WithMany(user => user.Tasks).HasForeignKey(e => e.AssigneeID);
            builder.HasOne(e => e.Project).WithMany(project => project.Tasks).HasForeignKey(e => e.ProjectID);
        }
    }
}
