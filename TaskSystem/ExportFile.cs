using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    class ExportFile
    {
        public static void ExportTxtFile(List<TaskSystem> listTask)
        {
            if (listTask.Count > 0)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "TaskFile.txt";
                using(FileStream file= new FileStream(path, (FileMode)FileAccess.Write, (FileAccess)FileMode.Create))
                {
                    using(StreamWriter textFile=new StreamWriter(file))
                    {
                        textFile.WriteLine("\tTaskId\tTaskTitle\tTaskDescription\tTaskCreatedDate\tTaskToComplete");
                        foreach(var tasks in listTask)
                        {
                            textFile.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                            textFile.WriteLine($"\t{tasks.TaskId}\t{tasks.TaskTitle}\t{tasks.TaskDescription}\t{tasks.TaskCreatedDate}\t{tasks.TaskToComplete}");
                            textFile.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("task successfully inserted into txt file");
                

            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
    }
}
