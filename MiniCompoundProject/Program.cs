using System;
using System.Collections.Generic;

namespace MiniCompoundProject
{
    internal class Program
    {

        public static void AddAcount()
        {

        }



        public static void DepositMoney()
        {

        }



        public static void WithdrawMoney()
        {

        }



        public static void ShowBalance()
        {

        }



        public static void TransferAmount()
        {

        }



        public static void ChangeAccountNumber()
        {

        }



        public static void ListAllAcounts()
        {

        }



        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balance = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("   Welcome to Spark Banking System   ");
                Console.WriteLine("      What service do you want?   ");

                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Change Account Number");
                Console.WriteLine("7. List All Accounts");
                Console.WriteLine("8. Exit");

                Console.WriteLine("Choose one of available services: ");

                int userChoise;

                try
                {
                    userChoise = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Choise! Please select option from the menu.");
                    continue;
                }

                switch (userChoise)
                {
                    case 1:
                        AddAcount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        TransferAmount();
                        break;

                    case 6:
                        ChangeAccountNumber();
                        break;

                    case 7:
                        ListAllAcounts();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choise! please enter service from the list.");
                        break;
                }


            }

        }
    }
}
