namespace homework8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int sign = 1;

            while (n > 0)
            {
                int digit = n % 10;

                sum += digit * sign;

                sign = -sign;

                n = n / 10;
            }

            Console.WriteLine("Сумма цифр с чередующимися знаками: " + sum);
        }
    }
}
