namespace homework7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Позиция белого слона: ");
            string white = Console.ReadLine();
            
            Console.WriteLine("Позиция черного ферзя: ");
            string black = Console.ReadLine();

            int wf, wr, bf, br;

            if (!Decode(white, out wf, out wr) || !Decode(black, out bf, out br))
                Console.WriteLine("Ошибка: позиция не соответствует шахматной доске");
            else if (wf == bf && wr == br)
                Console.WriteLine("Ошибка: фигуры стоят на одной клетке");
            else if (BishopAttacks(wf, wr, bf, br))
                Console.WriteLine("Белый слон бьет черного ферзя");
            else if (QueenAttacks(bf, br, wf, wr))
                Console.WriteLine("Черный ферзь бьет белого слона");
            else
                Console.WriteLine("Фигуры не бьют друг друга");

        }

        static bool Decode(string pos, out int file, out int rank)
        {
            file = 0;
            rank = 0;

            if (pos.Length != 2 || pos[0] < 'a' || pos[0] > 'h' || pos[1] < '1' || pos[1] > '8')
                return false;
            
            file = pos[0] - 'a' + 1;
            rank = pos[1] - '0';
            return true;
        }

        static bool BishopAttacks(int f, int r, int tf, int tr)
        {
            return Math.Abs(f - tf) == Math.Abs(r - tr);
        }

        static bool QueenAttacks(int f, int r, int tf, int tr)
        {
            return f == tf || r == tr || Math.Abs(f - tf) == Math.Abs(r - tr);
        }
    }
}
