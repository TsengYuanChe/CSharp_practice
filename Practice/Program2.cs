public class Program2
{
    public static void HowOld()
    {
        Console.WriteLine("請輸入年紀：");
        int c = Console.Read();  
        char age = (char)c; 
        Console.ReadLine();

        Console.WriteLine("請輸入名字：");
        string str = Console.ReadLine();  
        Console.WriteLine(str + "今年" + age + " 歲");
    }
}