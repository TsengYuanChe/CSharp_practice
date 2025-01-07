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
                case "P3":
                    Program3.Info();
                    break;
                case "P4":
                    Program4.Perimeter();
                    break;
                case "P5":
                    Program5.Circle();
                    break;
                case "P6":
                    Program6.DataType();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please provide which program.");
        }
    }
}