namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Calculate(2, 3) + Calculate(7, 8) + Calculate (1, 4);

            Console.WriteLine($"x = {x:F3}");
        }

        static double Calculate(double a, double b)
        {
            return Math.Sqrt(a + Math.Tan(b)) / (a * a + b * b);
        }
    }
}
