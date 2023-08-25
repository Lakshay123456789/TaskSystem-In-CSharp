using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskSystem
{
   public static class ValidationUtilty
    {

        public static string TitleValidation()
        {
            string taskTitle;

            while (true)
            {
                Console.WriteLine("Enter task Title  atleast 3 characters length ");
                taskTitle = Console.ReadLine().ToLower();
                Regex regex = new Regex(@"^[^\s][a-z\sA-Z\s0-9\s-()][^\s$]");
                Match match = regex.Match(taskTitle);
                if (match.Success && !(taskTitle.Any(Char.IsDigit)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid title ,please enter correct task title");
                    Console.WriteLine();
                }

            }
            return taskTitle;
        }
        public static string  DescriptionValidation()
        {
            string taskDescription;

            while (true)
            {
                Console.WriteLine("Enter task Description atleast 10 characters length ");
                taskDescription = Console.ReadLine().ToLower();
                Regex regex = new Regex(@"^[^\s][a-z\sA-Z\s0-9\s-()][^\s$]");
                Match match = regex.Match(taskDescription);
                if (match.Success && !(taskDescription.Any(Char.IsDigit))  && taskDescription.Length>9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Description ,please enter correct task Description");
                    Console.WriteLine();
                }

            }
            return taskDescription;
        }

        public static string TaskIdValidation()
        {
            string taskId;

            while (true)
            {

                Console.WriteLine("Enter the Task Id :- ");
                taskId = Console.ReadLine();
                Guid id;
                if (Guid.TryParse(taskId, out id))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid format of task Id");
                    Console.WriteLine();
                }
            }
            return taskId;
        }
    }
}
