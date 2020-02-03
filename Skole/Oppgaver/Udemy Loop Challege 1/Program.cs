using System;

namespace Udemy_Loop_Challege_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine("last nubmer was " +currentNumber);
                Console.WriteLine("please enter the next score");
                Console.WriteLine("curerent amount of entris "+ count);
                Console.WriteLine("please enter -1 once you are ready to calculatethe average");
                input = Console.ReadLine();

                if (input.Equals("-1"))
                {
                    Console.WriteLine("-----------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("the average score is "+average);
                }
                if (int.TryParse(input, out currentNumber)&& currentNumber>0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }
                count++;
            }
            Console.ReadLine();
            
        }
    }
}
