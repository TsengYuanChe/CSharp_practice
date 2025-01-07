using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            switch (args[0])
            {
                case "P1":
                    Program1.Execute();
                    break;
                case "P2":
                    Program2.HowOld();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please provide which program.");
        }
    }
}