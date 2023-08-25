using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class TaskSystem
    {
       public string TaskId { get; set; }

        public string TaskTitle { get; set; }

        public string TaskDescription { get; set; }

        public DateTime TaskCreatedDate { get; set; }

        public bool TaskToComplete { get; set; }

    }
}
