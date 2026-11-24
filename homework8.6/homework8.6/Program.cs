namespace homework8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите k (от 2 до 10): ");
            int k = int.Parse(Console.ReadLine());

            if (a >= b || k < 2 || k > 10)
            {
                Console.WriteLine("Некорректные значения");
                return;
            }

            Console.WriteLine("Подходящие числа: ");

            for (int i = a; i <= b; i++)
            {
                if (i == 0)
                    continue;

                long number = Math.Abs((long)i);
                long sum = 0;

                for (long j = 1; j <= number; j++)
                {
                    if (number % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum % k == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
