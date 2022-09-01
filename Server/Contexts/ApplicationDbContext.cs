using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Stroom.Server.EfConfigurations;
using Stroom.Server.Models;
using Stroom.Shared.Models;

namespace Stroom.Server.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<TaskDto> Tasks { get; set; }
        public virtual DbSet<ProjectDto> Projects { get; set; }
        public virtual DbSet<TimeEntry> TimeEntries { get; set; }
        public virtual DbSet<User> Users { get; set; }

        private readonly IConfiguration _configuration;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TimeEntryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CommentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TaskEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectEntityConfiguration());

            var user = new User()
            {
                UserID = 1,
                Name = "Hlib",
                Surname = "Pivniev",
                Email = "gl.pvn12@gmail.com",
                Role = Shared.Enums.UserPropertiesEnums.UserRole.Unassigned,
            };
            var project = new ProjectDto()
            {
                ProjectID = 1,
                Name = "Moon colony",
                Description = "Moon landing program"
            };
            var task = new TaskDto()
            {
                TaskID = 1,
                Name = "Change start button color",
                Description = "Name speaks itself",
                AssigneeID = 1,
                Priority = Shared.Enums.TaskPropertiesEnums.TaskPriority.Low,
                Status = Shared.Enums.TaskPropertiesEnums.TaskStatus.New,
                EstimatedTime = 13,
                SubmitionDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                ProjectID = 1
            };
            var timeEntry = new TimeEntry()
            {
                Date = DateTime.Now.AddDays(-2),
                TaskID = 1,
                UserID = 1,
                Hours = 3
            };
            var comment = new CommentDto()
            {
                TaskID = 1,
                UserID = 1,
                TimeStamp = DateTime.Now.AddDays(1),
                Comment = "Task is complicated..."
            };

            modelBuilder.Entity<User>().HasData(user);
            modelBuilder.Entity<ProjectDto>().HasData(project);
            modelBuilder.Entity<TaskDto>().HasData(task);
            modelBuilder.Entity<TimeEntry>().HasData(timeEntry);
            modelBuilder.Entity<CommentDto>().HasData(comment);
        }
    }
}
