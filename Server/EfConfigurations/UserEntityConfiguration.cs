using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stroom.Shared.Models;


namespace Stroom.Server.EfConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(e => e.UserID).HasName("User_PK");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Surname).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(256);
            builder.Property(e => e.Role).IsRequired();

            builder.HasMany(e => e.Tasks).WithOne(task => task.Assignee);

            builder.HasMany(e => e.Projects).WithMany(project => project.AssignedUsers);
        }
    }
}
