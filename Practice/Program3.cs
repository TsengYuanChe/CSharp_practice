public class Program3
{
    public static void Info()
    {
        double amount = 50123.45;
        int height = 176, weight = 68;
        var len = 150;
        var title = "My information";
        string name = "Adam";
        Console.WriteLine(title + ":");
        Console.WriteLine("姓名：" + name);
        Console.WriteLine("身高：" + height);
        Console.WriteLine("體重：" + weight);
        Console.WriteLine("腿長：" + len);
        Console.WriteLine("存款：" + amount);
    }
}