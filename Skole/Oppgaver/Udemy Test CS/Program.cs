using System;

namespace Udemy_Test_CS
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Write the first number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you wrote " + input1 + " please write the secound number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            double result = input1 + input2;
            //Console.WriteLine("the answer of "+ input1 +" + " +input2+ " is "+ result );
            Console.WriteLine($"the answer of {input1} + {input2} = {result}");
            //Console.WriteLine("the answer of {0} + {1} = {2}", input1, input2, result);
            double result2 = (input1 + input2) / 0;
            Console.WriteLine($"dividing by 0 ({input1} + {input2})/0 = {result2}");
        }
    }
}
