namespace homework7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(AllNegative(k, m, n));
        }

        static bool AllNegative(int k, int m, int n)
        {
            return k < 0 && m < 0 && n < 0;
        }
    }
}
