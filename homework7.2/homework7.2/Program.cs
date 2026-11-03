namespace homework7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(InRegion(x, y));
        }
        static bool InRegion(double x, double y)
        {
            return y >= 1 || y <= -3;
        }
    }
}
