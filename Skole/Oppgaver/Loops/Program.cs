using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            for (int i=0; i<50; i++)
            {
                if (isOdd(i))
                {
                    Console.WriteLine(i);
                }

            }

            int counter = 0;
            int lengthOfText = 0;

            do
            {
                Console.WriteLine("enter name of friend");
                string NameOfFrined = Console.ReadLine();
                int currentLeangth = NameOfFrined.Length;
                lengthOfText += currentLeangth;
                wholeText += NameOfFrined;
                Console.WriteLine(counter);
                counter++;
            } while (lengthOfText < 5);
            string enterText = "";

            while (counder < 10)
            {
                Console.WriteLine(counter<10);
                counter++;
            }
            

        }

        public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
