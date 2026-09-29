namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый катет:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Второй катет:");
            double b = double.Parse(Console.ReadLine());
            double area = (a * b) / 2;
            double c = Math.Sqrt(a * a + b * b);
            double perimeter = a + b + c;
            Console.WriteLine($"Площадь: {area}");
            Console.WriteLine($"Периметр: {perimeter}");
        }
    }
}
