using System.Text;
namespace homework6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском: ");
            string input = Console.ReadLine() ?? "";

            Console.WriteLine("Текст в стиле Cs: " + ToCs(input));
        }

        static Dictionary<char, string> CsAlphabet = new Dictionary<char, string>
        {
            {'а', "A"}, {'б', "6"}, {'в', "B"}, {'г', "r"}, {'д', "D"},
            {'е', "E"}, {'ё', "E"}, {'ж', "}|{"}, {'з', "3"}, {'и', "u"},
            {'й', "u*"}, {'к', "K"}, {'л', "JI"}, {'м', "M"}, {'н', "H"},
            {'о', "O"}, {'п', "n"}, {'р', "P"}, {'с', "C"}, {'т', "T"},
            {'у', "Y"}, {'ф', "cp"}, {'х', "X"}, {'ц', "L|"}, {'ч', "4"},
            {'ш', "LLI"}, {'щ', "LLL"}, {'ъ', "`b"}, {'ы', "bI"}, {'ь', "b"},
            {'э', "-)"}, {'ю', "IO"}, {'я', "9I"}
        };

        static string ToCs(string text)
        { 
            var sb = new StringBuilder();

            foreach (char c in text)
            {
                if (CsAlphabet.TryGetValue(char.ToLower(c), out string replacement))
                    sb.Append(replacement);
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
