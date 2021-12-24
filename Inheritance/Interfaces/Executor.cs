namespace Interfaces // Note: actual namespace depends on the project name.
{
    public class Executor : IActivity
    {
        public void Execute(string name)
        {
            Console.WriteLine(name + " was executed by Executor");
        }
    }
}