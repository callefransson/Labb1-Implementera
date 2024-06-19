using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    internal class Startup
    {
        //Method for runnning the program
        public void Run()
        {
            //Gets the singleton instance of TaskManager
            TaskManager taskManager = TaskManager.Instance;
            //Creates a new instance of TaskListView that implements IObserver
            IObserver listView = new TaskListView();

            //Registers the listView as an observer to the taskManager
            taskManager.RegisterObserver(listView);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Add Meeting Task");
                Console.WriteLine("2. Add House Task");
                Console.WriteLine("3. Add Other Task");
                Console.WriteLine("4. Show All Tasks");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                Console.Write('\n');
                string choice = Console.ReadLine();

                //A switch case statement, depending on which choice is made, a new Task is created using the TaskFactory
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the description for the meeting task: ");
                        string meetingDescription = Console.ReadLine();
                        ITask meetingTask = TaskFactory.CreateTask(TaskCategory.MeetingTask);
                        taskManager.AddTask(meetingTask, meetingDescription);
                        break;
                    case "2":
                        Console.Write("Enter the description for the house task: ");
                        string houseDescription = Console.ReadLine();
                        ITask houseTask = TaskFactory.CreateTask(TaskCategory.HouseTask);
                        taskManager.AddTask(houseTask, houseDescription);
                        break;
                    case "3":
                        Console.Write("Enter the description for the other task: ");
                        string otherDescription = Console.ReadLine();
                        ITask otherTask = TaskFactory.CreateTask(TaskCategory.OtherTask);
                        taskManager.AddTask(otherTask, otherDescription);
                        break;
                    case "4":
                        //Returns alla tasks
                        var tasks = taskManager.GetTasks();
                        //If there are no tasks
                        if (tasks == null || tasks.Count == 0)
                        {
                            Console.WriteLine("You have no current tasks");
                        }
                        else
                        {
                            //Displays all the tasks
                            Console.WriteLine("Current tasks:");
                            foreach (var task in tasks)
                            {
                                Console.WriteLine(task);
                            }
                        }
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
