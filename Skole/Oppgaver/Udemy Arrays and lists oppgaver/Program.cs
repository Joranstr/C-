using System;

namespace Udemy_Arrays_and_lists_oppgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int counter = 0;
            int i=0;

            foreach (var k in nums)
            {

                Console.WriteLine($"element = {counter}, {nums[i]}, {i}" );
                counter++;
                nums[i] = i;
                i++;

            }
        }
    }
}
