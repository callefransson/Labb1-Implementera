using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //This is the concrete observer that will display that a task was upadated and also list all the tasks
    public class TaskListView : IObserver
    {
        public void Update(List<string> tasks)
        {
            Console.WriteLine("Task List was updated");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
