namespace Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Phi = (1+);

            int number = 2;

            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(number++ + ++number);
            Console.WriteLine(number);

            number += 3;
            Console.WriteLine(number);

            Console.WriteLine(Phi - (1 + 1 / Phi));

            //числа Фибоначчи

            Console.WriteLine("Введите номер члена последовательности Фибоначчи");
            var n = int.Parse(Console.ReadLine());

            int fn = (int)((Math.Pow(Phi, n) - Math.Pow(1-, n) * Math.Pow(Phi, -n)) / Math.Sqrt(5));

            Console.WriteLine(fn);

            double x = 50;
            Console.WriteLine(x);
        }
    }
}
