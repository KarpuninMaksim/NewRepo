namespace homework8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int x;

            Console.WriteLine("Введите последовательность чисел (для завершения введите 0):");

            do
            {
                x = int.Parse(Console.ReadLine());

                if (x != 0 && x % 2 == 0)
                {
                    count++;
                }
            } while (x != 0);

            Console.WriteLine($"Количество четных чисел в последовательности: " + count);

        }
    }
}
