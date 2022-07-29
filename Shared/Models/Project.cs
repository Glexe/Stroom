using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroom.Shared.Models
{
    public class Project
    {
        public string Name { get; set; } = "New Project";
        public IEnumerable<Issue> AssignedIssues;
    }
}
