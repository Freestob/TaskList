﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TaskList
{
    public class TaskList 
    {
        private List<TaskList> ListOfTasks = new List<TaskList>();

        public void AddTask(TaskList task)
        {
            Console.WriteLine("Who's task is this?");
            string taskOwner = Console.ReadLine();
            Console.WriteLine("What needs to be accomplished?");
            string getDone = Console.ReadLine();
            Console.WriteLine("When does this need to be completed?");
            string dueDate = Console.ReadLine();
            ListOfTasks.Add(taskOwner, getDone, dueDate);

        }
        public void Display()
        {
            for (int i = 0; i < ListOfTasks.Count; i++)
            {
                Console.WriteLine($"{ListOfTasks[i]}");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Which task would you like to delete?");
            var userDeletion = int.Parse(Console.ReadLine());
            for (int d = 0; d< ListOfTasks.Count; d++)
            {
                if (d == userDeletion)
                {
                    Console.WriteLine("Are you sure that you want to delete this? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        ListOfTasks.Remove(ListOfTasks[d]);
                        
                    }
                    else if (Console.ReadLine() == "n")
                    {
                        Console.WriteLine("Let's keep going then");
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option");
                        
                    }
                }
            }

        }
        public void Complete()
        {
            Console.WriteLine("Which task would you like to mark complete?");
            var userComplete = int.Parse(Console.ReadLine());
            for (int c = 0; c < ListOfTasks.Count; c++)
            {
                if (c== userComplete)
                {
                    
                }

            }
        }
        
        


    }
}
