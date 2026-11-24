namespace homework8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p0 = 1.29;
            double C = 1.25 * Math.Pow(10, -4);

            Console.Write("Введите n от 10 до 100: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 10 || n > 100)
            {
                Console.WriteLine("Неверное значение n. Введите число от 10 до 100.");
                return;
            }
            
            Console.WriteLine("Высота (м)\tПлотность (кг/м^3)");

            for (int h = 0; h <= n * 100; h += 100)
            {
                double p = p0 * Math.Exp(-C * h);
                Console.WriteLine($"{h}\t\t{p:F6}");
            }
        }
    }
}
