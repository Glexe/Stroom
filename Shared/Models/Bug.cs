using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stroom.Shared.Enums.BugPropertiesEnums;

namespace Stroom.Shared.Models
{
    public class Bug
    {
        public int BugID { get; set; } = 1404;
        public string Name { get; set; } = "Laborum adipisicing culpa";
        public string Description { get; set; } = "Elit nisi ad excepteur aliquip cupidatat aliquip occaecat consectetur ex. Non culpa laborum pariatur mollit anim et nisi quis sint enim consequat fugiat consequat labore. Occaecat Lorem dolore irure esse et est adipisicing deserunt.";
        public string Owner { get; set; } = "James Green";
        public string Assignee { get; set; } = "Emma Wills";
        public BugPriority Priority { get; set; } = BugPriority.Low;
        public BugStatus Status { get; set; } = BugStatus.New;
        public float EstimatedTime { get; set; } = 1;
        public float WorkedTime { get; set; } = 0f;
        public DateTime? SubmitionDate { get; set; } = DateTime.Today;
        public DateTime? DueDate { get; set; } = DateTime.Today.AddDays(1);
        public ProjectDto Project { get; set; } = new ProjectDto();
        public List<BugComment> Comments { get; set; } = new List<BugComment>();
    }
}
