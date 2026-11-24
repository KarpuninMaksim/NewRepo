namespace homework8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n:");
            int n = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 0;
            int sum = 0;

            while (a <= n)
            {
                sum += a;

                int c = a + b;
                b = a;
                a = c;
            }

            Console.WriteLine("Сумма чисел Фибоначчи: " + sum);
        }
    }
}
