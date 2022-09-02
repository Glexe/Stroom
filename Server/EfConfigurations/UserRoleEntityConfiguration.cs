using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stroom.Shared.Models;


namespace Stroom.Server.EfConfigurations
{
    public class UserRoletEntityConfiguration : IEntityTypeConfiguration<UserRoleDto>
    {
        public void Configure(EntityTypeBuilder<UserRoleDto> builder)
        {
            builder.ToTable("UserRole");
            builder.HasKey(e => new { e.ProjectID, e.UserID }).HasName("UserRole_PK");
            builder.Property(e => e.Role).IsRequired();

            builder.HasOne(e => e.User).WithMany(task => task.UserRoles).HasForeignKey(e => e.UserID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Project).WithMany(user => user.UserRoles).HasForeignKey(e => e.ProjectID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
