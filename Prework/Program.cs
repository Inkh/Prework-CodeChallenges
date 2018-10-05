using System;

namespace Prework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3 };
            int[] selectArr = { 6, 4, 4, 1, 3 };
            Console.WriteLine($"Perfect Sequence --- Input: [{string.Join(",", myArr)}]... Expected Output: Yes, Output: {PerfectSequence(myArr)}.");
            Console.WriteLine($"Selection --- Input: ([{string.Join(",", selectArr)}], 4)... Expected Output: 8, Output: {Selection(selectArr, 6)}.");
        }

        static int Selection(int[] arr, int num)
        {
            int counter = 0;
            foreach (int ele in arr)
            {
                if (ele == num)
                {
                    counter++;
                }
            }
            return num*counter;
        }

        static bool LeapYear(int year)
        {
            return true;
        }

        static string PerfectSequence(int[] arr)
        {
            int sum = 0;
            int product = 1;
            foreach (int num in arr)
            {
                sum += num;
                product *= num;
            }
            if (sum == product)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
