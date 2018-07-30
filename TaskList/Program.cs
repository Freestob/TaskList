using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList;


namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do today?");
            // Need to write main menu
            var userEntry = Console.ReadLine();

            
           if (userEntry == "tasks")
            {
                TaskList.Display();
            }
            else if (userEntry == "add")
            {
                TaskList.AddTask();
            }
            else if (userEntry == "delete")
            {
                TaskList.Delete();    
            }
           else if (userEntry == "complete")
            {
                TaskList.Complete();
            }
        }
    }
}
