using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace LoopErrorHandlingSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop & Error Handling Task

            // Task 1: Countdown Timer

            //int CountDownNum = 0;
            //int countDown;

            //Console.WriteLine("Enter a number to countdown from: ");
            //CountDownNum = int.Parse(Console.ReadLine());

            //for(countDown = CountDownNum; countDown >= 1; countDown--)
            //{
            //    Console.WriteLine(countDown);
            //}

            //Console.WriteLine("Liftoff!");

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 2: Sum of Numbers 1 to N

            int n = 1;
            int sum = 0;

            Console.WriteLine("Enter a positive whole number: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum from 1 to " + n + " is " + sum);
        }
    }
}
