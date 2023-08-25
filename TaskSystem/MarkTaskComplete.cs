using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class MarkTaskComplete
    {

        public static void MarkTaskAsComplete(List<TaskSystem> listTask)
        {
            if (listTask.Count > 0)
            {
                string TaskId = ValidationUtilty.TaskIdValidation();
                foreach (var tasks in listTask)
                {
                    if (tasks.TaskId == TaskId)
                    {
                        tasks.TaskToComplete = true;
                        Console.WriteLine();
                        Console.WriteLine("This task mark as complete successfully");
                        return;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("this task id not exit in  task  list ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
    }
}
