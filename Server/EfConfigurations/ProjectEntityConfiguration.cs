using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stroom.Shared.Models;

namespace Stroom.Server.EfConfigurations
{
    public class ProjectEntityConfiguration : IEntityTypeConfiguration<ProjectDto>
    {
        public void Configure(EntityTypeBuilder<ProjectDto> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(e => e.ProjectID).HasName("Project_PK");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Description).HasMaxLength(2048);

            builder.HasMany(e => e.AssignedUsers).WithMany(user => user.Projects);
            builder.HasMany(e => e.Tasks).WithOne(task => task.Project);
        }
    }
}
