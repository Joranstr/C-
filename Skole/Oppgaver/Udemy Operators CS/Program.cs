using System;

namespace Udemy_Operators_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            int num3;

            //unarry operators
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"is it sunny? {isSunny}");

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is{0}",num);
            Console.WriteLine("num is{0}",++num);
            //pre increment
            Console.WriteLine("num is{0}",num++);

            //decrement operator

            num--;
            Console.WriteLine("num is {0}",num);
            Console.WriteLine("num is {0}",num--);
            Console.WriteLine("num is {0}",--num);

            int result;
            result = num1 + num2;
            Console.WriteLine(result);
            result = num1 - num2;
            Console.WriteLine(result);
            result = num1 * num2;
            Console.WriteLine(result);
            result = num1 / num2;
            Console.WriteLine(result);
            result = num1 % num2;
            Console.WriteLine(result);

            //relational an type operators

            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine(isLower);
            isLower = num1 > num2;
            Console.WriteLine(isLower);

            //equeality operator 
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine(isEqual);

            //conditinal operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine(isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine(isLowerAndSunny);



            Console.ReadKey();
        }
    }
}
