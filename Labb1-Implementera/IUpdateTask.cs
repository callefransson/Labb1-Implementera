using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Here we implement a observer interface to update tasks
    public interface IUpdateTask
    {
        void Update(List<string> tasks);
    }
}
