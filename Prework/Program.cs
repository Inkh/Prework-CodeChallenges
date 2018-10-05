using System;

namespace Prework
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInput();
            int[] myArr = { 1, 2, 3 };
            int[,] sumArr = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int yearOne = 1900;
            int yearTwo = 2000;
            int yearThree = 1996;
            int yearFour = 1997;
            Console.WriteLine($"Perfect Sequence --- Input: [{string.Join(",", myArr)}]... Expected Output: Yes, Output: {PerfectSequence(myArr)}.");
            Console.WriteLine($"2D Sum --- Input: [[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15]... Expected Output: [15, 40, 65], Output: [{string.Join(",",Sum(sumArr))}].");
            Console.WriteLine($"Leap Year --- Input: {yearOne} Expected Output: False, Output: {LeapYear(yearOne)}");
            Console.WriteLine($"Leap Year --- Input: {yearTwo} Expected Output: True, Output: {LeapYear(yearTwo)}");
            Console.WriteLine($"Leap Year --- Input: {yearThree} Expected Output: True, Output: {LeapYear(yearThree)}");
            Console.WriteLine($"Leap Year --- Input: {yearFour} Expected Output: False, Output: {LeapYear(yearFour)}");

        }
        static void UserInput()
        {
            int[] userArr = new int[5];
            string userInput;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input a number between 1 - 10: ");
                userInput = Console.ReadLine();
                bool flag = false;
                while (!flag)
                {
                    flag = true;
                    if (!int.TryParse(userInput, out int result))
                    {
                        Console.WriteLine("That was not a number, please try again: ");
                        userInput = Console.ReadLine();
                        flag = false;
                    }
                    else if (int.Parse(userInput) >= 10 || int.Parse(userInput) <= 1)
                    {
                        Console.WriteLine("Number out of range. Please input a number between 1-10: ");
                        userInput = Console.ReadLine();
                        flag = false;
                    }
                }
                userArr[i] = int.Parse(userInput);
            }
            Console.WriteLine($"[{string.Join(",", userArr)}] is your array. Please select one of the elements within for scoring: ");
            userInput = Console.ReadLine();
            bool flagTwo = false;
            while (!flagTwo)
            {
                flagTwo = true;
                if (!int.TryParse(userInput, out int result))
                {
                    Console.WriteLine("That was not a number, please try again: ");
                    userInput = Console.ReadLine();
                    flagTwo = false;
                }
            }
            Selection(userArr, int.Parse(userInput));
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
            Console.WriteLine($"Your array: [{string.Join(",", arr)}]. Your chosen number: {num}. Your Score: {num*counter}");
            return num*counter;
        }

        static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    return true;
                }
                else if (year % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        static string PerfectSequence(int[] arr)
        {
            int sum = 0;
            int product = 1;
            foreach (int num in arr)
            {
                if (num < 0)
                {
                    return "No";
                }
                sum += num;
                product *= num;
            }
            if (sum == product)
            {
                return "Yes";
            }
            return "No";
        }

        static int[] Sum(int[,] arr)
        {
            int[] result = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    sum += arr[i, k];
                }
                result[i] = sum;
            }
            return result;
        }
    }
}
