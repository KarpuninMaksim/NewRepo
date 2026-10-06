namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int n = int.Parse(Console.ReadLine());

            int last = n % 10;
            int firstTwo = n / 10;

            int result = last * 100 + firstTwo;
            Console.WriteLine($"Результат: {result}");
        }
    }
}
