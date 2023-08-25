using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class ShowAllTask
    {
        public static void ShowAllUserTask(List<TaskSystem> listTask)
        {
            if (listTask.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("TaskId\t\t\t\t\tTaskTitle\t\tTaskDescription\t\tTaskCreatedDate\tTasktoComplete");
                foreach(var tasks in listTask)
                {
                    if (tasks.TaskToComplete == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine($"{tasks.TaskId}\t{tasks.TaskTitle}\t\t{tasks.TaskDescription}\t\t{tasks.TaskCreatedDate}\t\t{tasks.TaskToComplete}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.WriteLine("list of task are empty");
            }
        }
    }
}
