using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    public class TaskManager : IObservable
    {
        private static TaskManager instance;
        private static readonly object lockObject = new object();
        //Private List to for tasks
        private List<string> tasks = new List<string>();
        //Private List to keep registerd observers
        private List<IObserver> observers = new List<IObserver>();

        //Creating a private empty constructor
        private TaskManager() { }
        //Implementing singelton design pattern so we can make sure the instance only runs ones
        public static TaskManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new TaskManager();
                        }
                    }
                }
                return instance;
            }
        }
        //Method for adding a new task, notifying observer that a change has been done
        public void AddTask(ITask task, string description)
        {
            task.ExecuteTask(description);
            tasks.Add(description);
            NotifyObservers();
        }
        //Method for removing a task, also notifying observer that a change has been done
        public void RemoveTask(string description)
        {
            tasks.Remove(description);
            NotifyObservers();
        }
        //Method for adding a observer
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        //Method for removing a observer
        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        //Method for notifying all observers if a change is made
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(tasks);
            }
        }
        //Method for returning tasks
        public List<string> GetTasks()
        {
            return tasks;
        }
    }
}
