using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class DeleteTask
    {
       public static void DeleteTaskUser(List<TaskSystem> listTask)
        {
            if (listTask.Count > 0) { 
            string taskId = ValidationUtilty.TaskIdValidation();
                foreach (var tasks in listTask)
                {
                    if (tasks.TaskId == taskId)
                    {
                        while (true)
                        {
                            Console.WriteLine("Are you want to Delete this Task(yes/no)");
                            String confirmationTask = Console.ReadLine().ToLower();
                            if (confirmationTask == "yes")
                            {
                                //    listTask.Remove(tasks);
                                Console.WriteLine();
                                Console.WriteLine("Soft delete succcessfully");
                                return;
                            }
                            else if (confirmationTask == "no")
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("invalid input");
                                Console.WriteLine();
                            }
                        }
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
