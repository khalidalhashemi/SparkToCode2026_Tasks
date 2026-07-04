using System.ComponentModel;
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

            //int n = 1;
            //int sum = 0;

            //Console.WriteLine("Enter a positive whole number: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + i;
            //}

            //Console.WriteLine("The sum from 1 to " + n + " is " + sum);

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 3: Multiplication Table

            //int number;
            //int mul = 0;

            //Console.WriteLine("Enter a number to start multiply: ");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    mul = number * i;

            //    Console.WriteLine("Your results: " + i + " * " + number + " = " + mul);
            //}

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 4: Passwoed Retry

            //bool exitDecision = false;
            //string correctPass = "Spark2026";
            //string Pass = correctPass;

            //while (exitDecision == false)
            //{
            //    Console.WriteLine("Enter the password: ");
            //    Pass = Console.ReadLine();

            //    if (Pass != correctPass)
            //    {
            //        Console.WriteLine("Invalid Password, please try again.");
            //    }
            //    else
            //    {
            //        exitDecision = true;
            //        Console.WriteLine("Access Granted.");
            //        break;
            //    }
            //}

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 5: Number Guessing Game

            bool exitDecision = false;
            int FixedNumber = 15;
            int Number;

            do
            {
                Console.WriteLine("Enter a random number to start guessing: ");
                Number = int.Parse(Console.ReadLine());

                if (Number > FixedNumber)
                {
                    Console.WriteLine("Too high.");
                    exitDecision = true;
                }
                else if (Number < FixedNumber)
                {
                    Console.WriteLine("Too low.");
                    exitDecision = true;
                }
                else if (Number == FixedNumber)
                {
                    Console.WriteLine("Correct.");
                    exitDecision = false;
                }
            }
            while (exitDecision);

        }
    }
}
