using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.CompilerServices;

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

            //bool exitDecision = false;
            //int FixedNumber = 15;
            //int Number;

            //do
            //{
            //    Console.WriteLine("Enter a random number to start guessing: ");
            //    Number = int.Parse(Console.ReadLine());

            //    if (Number > FixedNumber)
            //    {
            //        Console.WriteLine("Too high.");
            //        exitDecision = true;
            //    }
            //    else if (Number < FixedNumber)
            //    {
            //        Console.WriteLine("Too low.");
            //        exitDecision = true;
            //    }
            //    else if (Number == FixedNumber)
            //    {
            //        Console.WriteLine("Correct.");
            //        exitDecision = false;
            //    }
            //}
            //while (exitDecision);

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 6: Safe Division Calculator

            //float num1;
            //float num2;
            //float result;
            //float Divition;
            //bool exitDecision = false;

            //do
            //{
            //    Console.WriteLine("Enter the first number: ");
            //    num1 = float.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the second number to be divide: ");
            //    num2 = float.Parse(Console.ReadLine());

            //    try
            //    {
            //        Divition = num1 / num2;

            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Error! " + num1 + " cannot be divided by zero.");
            //            exitDecision = true;
            //        }
            //        else
            //        {
            //            Divition = num1 / num2;
            //            Console.WriteLine("The resulte is: " + Divition);
            //            exitDecision = true;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            //}
            //while (exitDecision);

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 7: Repeating Menu with Exit Option

            //bool exitDecision = false;


            //while (exitDecision == false)
            //{
            //    Console.WriteLine("Please select an option from the menu: ");
            //    Console.WriteLine("1. Introduction");
            //    Console.WriteLine("2. Information");
            //    Console.WriteLine("3. Exit");
            //    int userChoise = int.Parse(Console.ReadLine());



            //    switch (userChoise)
            //    {
            //        case 1:
            //            Console.WriteLine("Say Helloe.");
            //            break;

            //        case 2:
            //            Console.WriteLine("Wellcome to the resturant.");
            //            break;

            //        case 3:
            //            Console.WriteLine("Exit");
            //            exitDecision = true;
            //            break;

            //        default:
            //            Console.WriteLine("Invalid option.");
            //            break;
            //    }

            //}

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 8:  Sum of Even Numbers Only

            //int n = 0;
            //int sum;

            //Console.WriteLine("Enter a positive whole numebr: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = i + n;

            //        Console.WriteLine("You result = " + sum + " only even numbers " + "untill " + n);
            //    }
            //}

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 9:  Validated Positive Number Input

            //int PositiveNumber = 0;
            //int sumOfNumber;
            //bool exit = false;

            //do
            //{
            //    Console.WriteLine("Enter a positive whole number: ");
            //    PositiveNumber = int.Parse(Console.ReadLine());

            //    if (PositiveNumber > 0 && PositiveNumber == (PositiveNumber))
            //    {
            //        Console.WriteLine("This is a positive whole number.");

            //        for (int i = 1; i <= PositiveNumber; i++)
            //        {
            //            sumOfNumber = i + PositiveNumber;

            //            Console.WriteLine("Your result = " + sumOfNumber);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a positive whole number.");
            //    }

            //    try
            //    {

            //        Console.WriteLine("Do you want to try again (y/n)");
            //        string userChoise = Console.ReadLine();

            //        if (userChoise == "yes")
            //        {
            //            exit = true;
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //while (exit);

            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 10: Simple ATM Simulation

            int userPIN;
            int PIN = 1234;
            int fixedBalance = 100;
            int maxAttempts = 3;
            int AvailableAttempts = 1;
            bool exit = false;
            int reciverNumber = 992211;
            int reciverAccount;
            int currentBalance;

            do
            {

                try
                {

                    Console.WriteLine("Enter PIN: ");
                    userPIN = int.Parse(Console.ReadLine());


                    if (userPIN != PIN)
                    {
                        maxAttempts--;
                        Console.WriteLine("Inccorect PIN. Please try again. " + " Left Attempts: " +maxAttempts);
                        exit = false;

                        if (maxAttempts < 1)
                        {
                            Console.WriteLine("Your account is blocked. You exceeded your attempts!");
                            Console.WriteLine("Please contact us to activate your account.");
                            exit = true;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Correct PIN");


                        Console.WriteLine("Choose your option: ");
                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("3. Check Balance");
                        Console.WriteLine("4. Exit");
                        int Service = int.Parse(Console.ReadLine());




                        switch (Service)
                        {

                            case 1:
                                Console.WriteLine("Deposit: ");
                                Console.WriteLine("Please Enter Reciver Acount number: ");
                                reciverAccount = int.Parse(Console.ReadLine());

                                if (reciverAccount != reciverNumber )
                                {
                                    Console.WriteLine("This account is not available.");
                                }
                                else
                                {
                                    Console.WriteLine("Enter how much you whant to deposit: ");
                                    int Deposit = int.Parse(Console.ReadLine());

                                    if (Deposit > fixedBalance)
                                    {
                                        Console.WriteLine("You don't have enough balance.");
                                        exit = true;
                                    }
                                    else
                                    {
                                        currentBalance =  fixedBalance - Deposit;
                                        Console.WriteLine("Deposit success! Your Current Balance: " + currentBalance);
                                    }
                                }
                                break;

                            case 2:
                                Console.WriteLine("Withdraw");
                                Console.WriteLine("Enter how much you want to Withdraw: ");
                                int Withdraw = int.Parse(Console.ReadLine());

                                if (Withdraw > fixedBalance)
                                {
                                    Console.WriteLine("You don't have enough balance.");
                                    exit = true;
                                }
                                else
                                {
                                    currentBalance =  fixedBalance - Withdraw;
                                    Console.WriteLine("Withdraw success");
                                    Console.WriteLine("Please collect your cash.");
                                    Console.WriteLine("Your current balance: " + currentBalance);
                                    exit = true;
                                }

                                break;

                            case 3:
                                Console.WriteLine("Check Balance");
                                Console.WriteLine("Your available balance: " + fixedBalance);
                                break;

                            case 4:
                                Console.WriteLine("Thank you!");
                                exit = true;
                                break;

                            default:
                                Console.WriteLine("You entered invalid choise. Please try again.");
                                exit = false;
                                break;
                        }

                        exit = true;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Failed, you entered invalid input"); 
                    Console.WriteLine(ex);
                }

            } while (!exit);



        }
    }
}
