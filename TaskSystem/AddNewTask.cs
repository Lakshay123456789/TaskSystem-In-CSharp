using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class AddNewTask
    {
        public static void AddNewTaskUser(List<TaskSystem> listTask)
        {

            TaskSystem newTask = new TaskSystem();

            Guid newTaskGuid = Guid.NewGuid();

            string taskId = newTaskGuid.ToString();

            string taskTitle = ValidationUtilty.TitleValidation();

            string taskDescription = ValidationUtilty.DescriptionValidation();

            DateTime createDate = DateTime.Now;

            // By default task is not complete set as false
            bool taskIsComplete = false;

            newTask.TaskId = taskId;

            newTask.TaskTitle = taskTitle;

            newTask.TaskDescription = taskDescription;

            newTask.TaskCreatedDate = createDate;

            newTask.TaskToComplete = taskIsComplete;

            listTask.Add(newTask);

            Console.WriteLine();
            Console.WriteLine("your task add successfully");

        }
    }
}
