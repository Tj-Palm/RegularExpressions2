using System;
using System.Text.RegularExpressions;

namespace RegularExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =
                "Two swindlers arrive at the capital city of an emperor who spends lavishly on clothing at the expense of state matters.Posing as weavers, they offer to supply him with magnificent clothes that are invisible to those who are stupid or incompetent.The emperor hires them, and they set up looms and go to work.A succession of officials, and then the emperor himself, visit them to check their progress.Each sees that the looms are empty but pretends otherwise to avoid being thought a fool.Finally, the weavers report that the emperor's suit is finished. They mime dressing him and he sets off in a procession before the whole city.The townsfolk uncomfortably go along with the pretense, not wanting to appear inept or stupid, until a child blurts out that the emperor is wearing nothing at all.The people then realize that everyone has been fooled.Although startled, the emperor continues the procession, walking more proudly than ever.";



            Regex rx = new Regex("(emperor|Emperor)");
            foreach (Match match in rx.Matches(input))
            {
                Console.WriteLine(match.Index);
            }

            foreach (var s in Regex.Matches(input, @"([^\.]*\.)"))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine(rx.Replace(input, "teacher"));
        }
    }
}
