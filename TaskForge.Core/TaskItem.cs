using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForge.Core
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int? ParentTaskId { get; set; }
        public string? Epic { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public TaskItemStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
