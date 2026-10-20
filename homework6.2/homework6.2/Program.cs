namespace homework6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "программа";

            string p = word.Substring(0, 1);
            string r = word.Substring(1, 1);
            string a = word.Substring(8);
            string ram = word.Substring(4, 3);

            string par = p + a + r;
            string rampa = ram + p + a;

            Console.WriteLine(par);
            Console.WriteLine(rampa);

        }
    }
}
