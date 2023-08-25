using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class Program
    {
        static void Main()
        {

            List<TaskSystem> ListTask = new List<TaskSystem>
          {
                new TaskSystem
                {
                    TaskId="155c5cbd-a25b-4c8e-a1e0-55c687b7136a",
                    TaskTitle="abc",
                    TaskDescription="newtaskgfhfghf",
                    TaskCreatedDate=DateTime.Now,
                    TaskToComplete=false,
                }
            };

            while (true)
            {
                bool quitApplication = false;
                Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\tTask Management System");
                Console.WriteLine("------------------------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("\t\t\t\t1.Add New Task");
                Console.WriteLine("\t\t\t\t2.Edit Task");
                Console.WriteLine("\t\t\t\t3.Delete Task");
                Console.WriteLine("\t\t\t\t4.Show All Task");
                Console.WriteLine("\t\t\t\t5.Mark Task As Complete");
                Console.WriteLine("\t\t\t\t6.Export All task Into Txt File");
                Console.WriteLine("\t\t\t\t7.Quit Application\n");
                Console.WriteLine("Enter the Choice from 1 to 7");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddNewTask.AddNewTaskUser(ListTask);
                            break;
                        case 2:
                            EditTask.EditTaskUser(ListTask);
                            break;

                        case 3:
                            DeleteTask.DeleteTaskUser(ListTask);
                            break;

                        case 4:
                            ShowAllTask.ShowAllUserTask(ListTask);
                            break;

                        case 5:
                            MarkTaskComplete.MarkTaskAsComplete(ListTask);
                            break;

                        case 6:
                            ExportFile.ExportTxtFile(ListTask);
                            break;

                        case 7:
                            quitApplication = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("invalid input choice ");
                            Console.WriteLine();
                            break;

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("invalid input ");
                    Console.WriteLine();
                }
                if (quitApplication)
                {
                    break;
                }
            }
          
            

        }
    }
}
