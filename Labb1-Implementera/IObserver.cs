namespace Labb1_Implementera
{
    //Defines a Interface for the observer that implements a method for updating them when a change has been made
    public interface IObserver
    {
        void Update(List<string> tasks);
    }
}