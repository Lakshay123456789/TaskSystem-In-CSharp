using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class EditTask
    {

        public static void EditTaskUser(List<TaskSystem> listTask)
        {
            if (listTask.Count > 0)
            {
                string TaskId = ValidationUtilty.TaskIdValidation();
                foreach(var tasks in listTask)
                {
                    if (tasks.TaskId == TaskId)
                    {
                        string taskTitle = ValidationUtilty.TitleValidation();

                        string taskDescription = ValidationUtilty.DescriptionValidation();

                        tasks.TaskTitle = taskTitle;

                        tasks.TaskDescription = taskDescription;

                        Console.WriteLine();

                        Console.WriteLine("edit this task successfully");

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
