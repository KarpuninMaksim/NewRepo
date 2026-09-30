namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = GetCoordinate("Введите 1-ю координату вектора");
            var y = GetCoordinate("Введите 2-ю координату вектора");

            var vectorlenght = Math.Sqrt(Square(x,y);

            Console.WriteLine("Длинна вектора равна " + vectorlenght);

            int sum = Square(1)+Square(5)+Square(7);
        }

        /// <summary>
        /// Ввод коордиаты вектора с консоли
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns></returns>
        
        static double GetCoordinate(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());

        }

        //static double Square(double x)
        //{
        //    return x * x;
        //}

        static double Square(double x) => x * x;

        static int Square(int x) => x * x;

        static double Square()
    }
}
