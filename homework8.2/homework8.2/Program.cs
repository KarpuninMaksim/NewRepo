namespace homework8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество сотрудников: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Введите зарплату сотрудника №" + i + ": ");
                double salary = double.Parse(Console.ReadLine());
                sum += salary;
            }

            Console.WriteLine($"Общая сумма зарплат сотрудников: " + sum);
        }
    }
}
