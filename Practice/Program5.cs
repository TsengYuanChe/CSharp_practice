public class Program5
{
    public static void Circle()
    {
        const double PI = 3.1415926;
        Console.Write("輸入半徑 =>");

        string Radius = Console.ReadLine() ?? "1";
        if (!int.TryParse(Radius, out int r))
        {
            Console.WriteLine("無效的輸入，使用預設半徑 1");
            r = 1; 
        }

        double a = PI * r * r;
        double p = 2 * PI * r;

        Console.WriteLine("圓半徑：" + r);
        Console.WriteLine("圓面積：" + a); 
        Console.WriteLine("圓周長：" + p);
    }
}