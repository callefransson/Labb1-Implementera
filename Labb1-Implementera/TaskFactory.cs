using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //This class we define a abstract factory class that will return new Tasks depending on what task is created
    public abstract class TaskFactory
    {
        //Static method that takes in a argument of type TaskCategory and returns an object that implements the ITask interface.
        public static ITask CreateTask(TaskCategory taskCategory)
        {
            switch(taskCategory)
            {
                case TaskCategory.HouseTask:
                    return new HouseTask();
                case TaskCategory.MeetingTask:
                    return new MeetingTask();
                case TaskCategory.OtherTask:
                    return new OtherTask();
                default:
                    throw new NotImplementedException(
                        $"{taskCategory} is not valid");
            }


        }
    }
}
