using System.Runtime.Intrinsics.X86;

namespace Task3Buil_inFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Absolute Difference

            //float sub;

            //Console.WriteLine("Enter first number: ");
            //float num1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //float num2 = float.Parse(Console.ReadLine());

            //sub = num2 - num1;

            //int Absolute = (int)Math.Abs(sub);

            //Console.WriteLine("The result is: " + Absolute);

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 2: Power & Root Explorer

            //int number;

            //Console.WriteLine("Enter a number: ");
            //number = int.Parse(Console.ReadLine());

            //double Power = Math.Pow(number, 2);

            //double squareRoot = Math.Sqrt(number);

            //Console.WriteLine("Your power of 2 is: " + Power);
            //Console.WriteLine("Your Square Root is: " + squareRoot);

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 3: Name Formatter

            //Console.WriteLine("Enter your full name: ");
            //string name = Console.ReadLine();

            //string upperName = name.ToUpper();

            //string lowerName = name.ToLower();

            //int lenght = name.Length;

            //Console.WriteLine("Your name in UpperCase: " + upperName);
            //Console.WriteLine("Your name in LowerCase: " + lowerName);
            //Console.WriteLine("Lenght of your name is: " + lenght);

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 4:  Subscription End Date

            //Console.WriteLine("Enter the days for free trial: ");
            //int freeTrial = int.Parse(Console.ReadLine());

            //DateTime startTrial = DateTime.Today;

            //DateTime endTrial = startTrial.AddDays(freeTrial);

            //Console.WriteLine("Your free trail ends on: " + endTrial);

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 5:  Grade Rounding System

            //Console.WriteLine("Enter your exam test in decimal: ");
            //float grade = float.Parse(Console.ReadLine());

            //double roundedGrade = Math.Round(grade);

            //if (roundedGrade >= 60)
            //{
            //    Console.WriteLine("You Passed!");
            //    Console.WriteLine("Your Grade is: " + grade);
            //    Console.WriteLine("Your Rounded Grade is: " + roundedGrade);
            //}
            //else
            //{
            //    Console.WriteLine("You Failed!");
            //    Console.WriteLine("Your Grade is: " + grade);
            //    Console.WriteLine("Your Rounded Grade is: " + roundedGrade);
            //}

            ///////////////////////////////////////////////////////////////////////////
            ///


            //// Task 6: Password Strength Checkersswor

            //string invalidPass = "Password";

            //Console.WriteLine("Enter a new password: ");
            //Console.WriteLine("Your password should contains at least 8 charchters and " +
            //                  "Should no be contains (password).");
            //string userPassword = Console.ReadLine();

            //int passwordLength = userPassword.Length;

            //if (passwordLength < 8)
            //{
            //    Console.WriteLine("Weak password.");
            //}
            //else if (userPassword.ToUpper() == invalidPass.ToUpper() || userPassword.ToLower() == invalidPass.ToLower())
            //{
            //    Console.WriteLine("Weak password.");
            //}
            //else if (passwordLength < 8 && userPassword.ToUpper() == invalidPass.ToUpper() || userPassword.ToLower() == invalidPass.ToLower())
            //{
            //    Console.WriteLine("Weak password.");
            //}
            //else
            //{
            //    Console.WriteLine("Strong password!");
            //}

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 6 (modified): Password Strength Checkersswor

            Console.WriteLine("Enter a new password: ");
            string userPassword = Console.ReadLine();

            bool passwordLength = userPassword.Length >= 8;

            bool contains = userPassword.Contains("Password".ToLower());

            if (passwordLength && contains == false)
            {
                Console.WriteLine("Strong Password!");
            }
            else if (contains)
            {
                Console.WriteLine("Weak Password.");
            }





        }
    }
}
