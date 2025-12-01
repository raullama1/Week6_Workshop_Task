using System;

namespace Task3
{
    public class Program
    {
        static void ProcessNumbers(int[] numbers, Func<int, bool>condition)
        {
            foreach (var num in numbers)
            {
                if (condition(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void Main(string[] args)
        {
            // assigning numbers
            int[] nums = { 1, 4, 7, 12, 14, 16, 74, 34};
            
            // print only even numbers
            Console.WriteLine("EVEN Numbers:");
            ProcessNumbers(nums, n => n % 2 == 0);
            
            // print only numbers greater than 10
            Console.WriteLine("\nNumbers Greather than 10:");
            ProcessNumbers(nums, n => n > 10);
        }
    }
}