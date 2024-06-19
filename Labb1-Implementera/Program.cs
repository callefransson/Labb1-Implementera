using System.Threading.Tasks;

namespace Labb1_Implementera
{
    internal class Program
    {
        //This is a simple To-do application with tree different designpatterns, which are Singelton, Observer and Facotry Method.
        //Observer pattern for creating one-to-many relation between objects, when a object has been changed we notity and update all objects automaticly
        //Factory Method for creating objects without specifying the exact class of the object to be created. This allows objects to be created dynamically based on certain inputs or conditions.
        //Singelton pattern to make sure that a class has a single instance and allows the object to be shared between multiple parts of the code. 
        static void Main(string[] args)
        {
            var runProgram = new Startup();
            runProgram.Run();
            
        }
    }
}
