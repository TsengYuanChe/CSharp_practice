using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "other")
        {
            MyOtherClass.Execute();
        }
        else
        {
            Console.WriteLine("Hello from Program!");
        }
    }
}