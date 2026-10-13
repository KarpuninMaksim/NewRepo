namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("f(x) = " + CalculateFunction(x));
        }

        static double CalculateFunction(double x)
        {
            double numerator = 2.0 / (x * x + 25) + Math.Cos(x);
            double denominator = Math.Sqrt (x * x * x * x + 1) + (Math.Sin(x) + Math.Cos(x)) / 2.0;

            return numerator / denominator;
        }

    }
}
