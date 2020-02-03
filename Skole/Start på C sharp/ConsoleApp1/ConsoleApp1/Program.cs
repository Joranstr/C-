using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = 250;
            readTextandUpdateAndshowCharCounts(range);
        }

        private static void readTextandUpdateAndshowCharCounts(int range)
        {
            var counts = new int[range];
            var tottalCounts = 0;
            //double percent = (counts/tottalCounts)*100;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower();
                tottalCounts = updateCharCounts(counts, tottalCounts, text);
                showCount(range, counts, tottalCounts);
            }
        }

        private static void showCount(int range, int[] counts, int tottalCounts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    double percent = 100 * (double)counts[i] / tottalCounts;
                    string output = character + " - " + percent.ToString("F2") + "%";
                    Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                    Console.WriteLine(character + " - " + output);
                }
            }
        }

        private static int updateCharCounts(int[] counts, int tottalCounts, string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
                tottalCounts++;
            }

            return tottalCounts;
        }
    }
}
