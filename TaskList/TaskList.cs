using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class TaskList 
    {
        private List<string> ListOfTasks = new List<string>();

        public void AddTask()
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
                Console.WriteLine(i++ $"{ListOfTasks.taskOwner}, {ListOfTasks.getDone}, {ListOfTasks.dueDate}");
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
                    ListOfTasks.Remove(ListOfTasks[d]);
                }
            }
        }
        public void Complete()
        {

        }
    }
}
