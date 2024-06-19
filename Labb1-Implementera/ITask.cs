using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Here we create an Interface for all types of tasks that will be implemented
    public interface ITask
    { 
        void ExecuteTask(string description);
    }
}
