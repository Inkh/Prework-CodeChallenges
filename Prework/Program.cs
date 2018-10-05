using System;

namespace Prework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3 };
            PerfectSequence(myArr);
            Console.WriteLine($"Input: [{string.Join(",", myArr)}]. Expected Output: Yes, Output: {PerfectSequence(myArr)}.");
        }

        static int Selection(int[] arr, int num)
        {
            return 24;
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
