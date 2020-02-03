using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEksempel1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMode();
            //Average();
            //SortDemo();
            //args = new[] {"10", "11", "12"};
            //FindMax(args);
            //Search(args);
        }

        private static void FindMode()
        {
            int[] surveyData = { 4, 7, 3, 8, 9, 7, 3, 9, 9, 3, 3, 10 };
            Array.Sort(surveyData);
            // {4, 7, 7, 9, 9, 9, 8, 3, 3, 3, 3, 10};
            int mostFrequent = -1;
            int highestFrequency = 0;
            int currentFrequency = 0;
            var arraySize = surveyData.Length;
            for (int i = 0; i < arraySize; i++)
            {
                currentFrequency++;
                if (i == arraySize - 1 || surveyData[i] != surveyData[i + 1])
                {
                    if (currentFrequency > highestFrequency)
                    {
                        highestFrequency = currentFrequency;
                        mostFrequent = surveyData[i];
                    }
                    currentFrequency = 0;
                }
            }

            Console.WriteLine($"Det var flest {mostFrequent}-ere ({highestFrequency}).");
        }

        private static void Average()
        {
            int[] gradeArray = { 87, 76, 100, 97, 64, 83, 88, 92, 74, 95 };
            double sum = 0;
            for (int i = 0; i < gradeArray.Length; i++)
            {
                sum += gradeArray[i];
            }
            double average = sum / gradeArray.Length;
            Console.WriteLine(average);
        }

        private static void SortDemo()
        {
            string[] txts = new[] { "Hei", "heio", "på", "deg", "hurramegrundt" };
            Console.WriteLine("Før sortering:");
            foreach (var txt in txts)
            {
                Console.WriteLine(txt);
            }
            Array.Sort(txts, Compare);
            Console.WriteLine("\nEtter sortering:");
            foreach (var txt in txts)
            {
                Console.WriteLine(txt);
            }

        }

        private static int Compare(string x, string y)
        {
            if (x.Length == y.Length) return x.CompareTo(y);
            if (x.Length > y.Length) return -1;
            return 1;
        }

        static void FindMax(string[] args)
        {
            int[] intArray = args.Select(s => Convert.ToInt32(s)).ToArray();
            var maxSoFar = intArray[0];
            var maxSoFarIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxSoFar)
                {
                    maxSoFar = intArray[i];
                    maxSoFarIndex = i;
                }
            }

            Console.WriteLine($"Det høyeste tallet er {maxSoFar} og ligger i indeks {maxSoFarIndex}.");
        }

        static void Search(string[] args)
        {
            int[] intArray = { 10, 20, 30 };
            int targetValue = Convert.ToInt32(args[0]);
            int targetPos = 0;
            while (targetPos < intArray.Length
                && intArray[targetPos] != targetValue)
            {
                targetPos++;
            }

            var isFound = targetPos < intArray.Length;
            var text = isFound
                ? $"Fant verdien {targetValue} i indeks {targetPos}."
                : $"Fant ikke verdien {targetValue}.";
            Console.WriteLine(text);
        }
    }
}