﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //This is a concrete class
    public class MeetingTask : ITask
    { 
        public void ExecuteTask(string description)
        {
            Console.WriteLine($"{description} has been created in meeting task category");
        }
    }
}
