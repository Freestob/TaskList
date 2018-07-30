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
           bool doAgain = true;

            do { 
                Console.WriteLine("Welcome to Task Manager Beta");
                Console.WriteLine("\t1. \tTask List");
                Console.WriteLine("\t2. \tAdd Task");
                Console.WriteLine("\t3. \tDelete Task");
                Console.WriteLine("\t4. \tMark Task Complete");
                Console.WriteLine("\t5. \tQuit");
            string userOption = (Console.ReadLine());
            switch(userOption)
            {
                case "1":
                    TaskList.Display();
                    break;
                case "2":
                    TaskList.AddTask();
                    break;
                case "3":
                    TaskList.Delete();
                    break;
                case "4":
                    TaskList.Complete();
                    break;
                case "5":
                    Console.WriteLine("Are you sure? (y/n)");
                    if (Console.ReadLine() == "y")
                        doAgain = false;
                    else
                    {
                        break;
                    }
            }
                while (doAgain == false) ;
        }
    }
}
