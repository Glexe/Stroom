using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Models
{
    public class Issue
    {
        public int IssueID { get; set; } = 1404;
        public string Name { get; set; } = "Laborum adipisicing culpa";
        public string Description { get; set; } = "Elit nisi ad excepteur aliquip cupidatat aliquip occaecat consectetur ex. Non culpa laborum pariatur mollit anim et nisi quis sint enim consequat fugiat consequat labore. Occaecat Lorem dolore irure esse et est adipisicing deserunt.";
        public string Owner { get; set; } = "James Green";
        public string Assignee { get; set; } = "Emma Wills";
        public string Priority { get; set; } = "High";
        public string Status { get; set; } = "In work";
        public float EstimatedTime { get; set; } = 4.5f;
        public float WorkedTime { get; set; } = 2f;
        public string SubmitionDate { get; set; } = "April 14, 2022";
        public string DueDate { get; set; } = "April 28, 2022";
        public Project Project { get; set; } = new Project();
    }
}
