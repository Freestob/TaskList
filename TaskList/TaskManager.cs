using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskL

{
    class TaskEntry
    {
        public string TaskOwner { get; set; }
        public string GetDone { get; set; }
        public string DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TaskEntry(string TaskOwner, string getDone, string dueDate)
        {
            TaskOwner = taskOwner;
            GetDone = getDone;
            DueDate = dueDate;
            IsCompleted = IsCompleted;
        }
    }
}
