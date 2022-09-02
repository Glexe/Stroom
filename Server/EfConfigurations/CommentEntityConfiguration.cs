using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stroom.Shared.Models;


namespace Stroom.Server.EfConfigurations
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<CommentDto>
    {
        public void Configure(EntityTypeBuilder<CommentDto> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(e => e.CommentID).HasName("Comment_PK");
            //builder.HasKey(e => new { e.TaskID, e.UserID }).HasName("Comment_PK");
            builder.Property(e => e.Comment).IsRequired().HasMaxLength(1024);
            builder.Property(e => e.TimeStamp).IsRequired().HasColumnType("datetime");

            builder.HasOne(e => e.Task).WithMany(task => task.Comments).HasForeignKey(e => e.TaskID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.User).WithMany(user => user.Comments).HasForeignKey(e => e.UserID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
