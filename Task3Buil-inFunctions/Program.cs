using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Security;

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

            //Console.WriteLine("Enter a new password: ");
            //string userPassword = Console.ReadLine();

            //bool passwordLength = userPassword.Length >= 8;

            //bool contains = userPassword.Contains("Password".ToLower());

            //if (passwordLength && contains == false)
            //{
            //    Console.WriteLine("Strong Password!");
            //}
            //else if (contains)
            //{
            //    Console.WriteLine("Weak Password.");
            //}

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 7: Clean Name Comparator

            //Console.WriteLine("Enter your name: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Confirm your name: ");
            //string userNameConfg = Console.ReadLine();

            //string trimmedUserName = userName.Trim().ToLower();

            //string trimmedUserName2 = userNameConfg.Trim().ToLower();

            //if (trimmedUserName == trimmedUserName2)
            //{
            //    Console.WriteLine("Name Match!");
            //}
            //else
            //{
            //    Console.WriteLine("Name Not Match.");
            //}

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 8: Membership Expiry Checker

            //try
            //{
            //    Console.WriteLine("Enter your membership start date: (mm/dd/yyyy)");
            //    DateTime membership = DateTime.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the valid membership days: ");
            //    int validDays = int.Parse(Console.ReadLine());

            //    DateTime currentDate = DateTime.Today;
            //    DateTime endmembership = membership.AddDays(validDays);

            //    if (currentDate <= endmembership)
            //    {
            //        Console.WriteLine("Your membership is active until: " + endmembership);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your membership is expired on: " + endmembership);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 9:  Round Up / Round Down Explorer

            //Console.WriteLine("Enter a decimal number to start rounding: ");
            //float decNumber = float.Parse(Console.ReadLine());

            //double nearestWholeNumber = Math.Round(decNumber);

            //double alwaysRoundedUp = Math.Ceiling(decNumber);

            //double alwaysRoundedDown = Math.Floor(decNumber);

            //Console.WriteLine("Result of " + decNumber + " rounded to the nearest whole number = " + nearestWholeNumber);

            //Console.WriteLine("Result of " + decNumber + " rounded always up = " + alwaysRoundedUp);

            //Console.WriteLine("Result of " + decNumber + " rounded always down = " + alwaysRoundedDown);

            ///////////////////////////////////////////////////////////////////////////
            ///



            // Task 10: Word Position Finder

            //Console.WriteLine("Enter a full sentence: ");
            //string sentence = Console.ReadLine();

            //Console.WriteLine("Enter a single word to find if it is exist in the sentence of not: ");
            //string sentenceWord = Console.ReadLine();

            //bool wordContains = sentence.Contains(sentenceWord);

            //int firstAppears = sentence.IndexOf(sentenceWord);

            //int lastApppears = sentence.LastIndexOf(sentenceWord);

            //if (wordContains)
            //{
            //    Console.WriteLine("The word appears in the sentence.");
            //    Console.WriteLine("The first appear in index: " + firstAppears);
            //    Console.WriteLine("The Last appear in index: " + lastApppears);
            //}
            //else
            //{
            //    Console.WriteLine("word not found.");
            //}

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 11: One-Time Password (OTP) Generator

            //int Attempts = 3;
            //int trueOTP;
            //bool Verification = false;
            //bool exit = false;

            //Console.WriteLine("Enter your phone number to sent OTP.");
            //int phoneNumber = int.Parse(Console.ReadLine());

            //Random OTP = new Random();

            //trueOTP = OTP.Next(1000, 9999);

            //Console.WriteLine("Your OTP is: " + trueOTP);

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter the OTP: ");
            //        int userOTP = int.Parse(Console.ReadLine());

            //        if (userOTP == trueOTP)
            //        {
            //            Verification = true;
            //            Console.WriteLine("OTP Verified!");
            //            exit = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid OTP.");
            //            exit = true;
            //            Attempts--;
            //        }

            //        if (Verification == false)
            //        {
            //            Console.WriteLine("Please Try again. You have left " + Attempts + " attempts");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    if (Attempts == 0)
            //    {
            //        Console.WriteLine("Verification Failed!");
            //        exit = false;
            //    }
            //}

            //while (exit) ;

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 12: Birthday Insights

            int age;

            try
            {

                Console.WriteLine("Enter your date of birth: ");
                DateTime DateOfBirth = DateTime.Parse(Console.ReadLine());

                int BirthMonth = DateOfBirth.Month;

                int BirthYear = DateOfBirth.Year;

                DateTime TodayDate = DateTime.Today;

                int CurrentYear = TodayDate.Year;

                Console.WriteLine("Is your birthday this year already happened? (yes/no)");
                string userInput = Console.ReadLine();

                if (userInput == "yes")
                {
                    age = CurrentYear - BirthYear;
                    Console.WriteLine("Your age is: " + age + " Born on " + DateOfBirth.DayOfWeek + " and " + BirthMonth + " month");
                }
                else
                {
                    age = (CurrentYear - BirthYear) - 1;
                    Console.WriteLine("Your age is: " + age + " Born on " + DateOfBirth.DayOfWeek + " and " + BirthMonth + " month");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
