using System;
using System.Collections.Generic;

namespace MiniCompoundProject
{
    internal class Program
    {

        public static void AddAcount()
        {

            string customerName;
            string accountNumber;
            double currentBalance = 0;

            Console.WriteLine("Enter your full name: ");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter a new account number: ");
            accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("This account number is already exists.");
            }
            else
            {
                Console.WriteLine("Initial Deposit is mandatory to activate your account.");

                double depositAmount;

                Console.WriteLine("Enter your account number: ");
                accountNumber = Console.ReadLine();

                int index = accountNumbers.IndexOf(accountNumber);

                if (index == -1)
                {
                    Console.WriteLine("Account not found!");
                }
                else
                {
                    Console.WriteLine("Enter deposit amount: ");
                    depositAmount = double.Parse(Console.ReadLine());

                    if (depositAmount < 0)
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    else
                    {
                        balance[0] = depositAmount;

                        currentBalance = depositAmount;
                    }

                }
            }

            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balance.Add(currentBalance);

        }



        public static void DepositMoney()
        {

            string accountNumber;
            double depositAmount;
            double currentBalance;

            Console.WriteLine("Enter your account number: ");
            accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found!");
            }
            else
            {
                Console.WriteLine("Enter deposit amount: ");
                depositAmount = double.Parse(Console.ReadLine());

                if (depositAmount < 0 )
                {
                    Console.WriteLine("Invalid amount.");
                }
                else
                {
                    balance[0] = depositAmount;

                    currentBalance = depositAmount;

                    balance.Add(currentBalance);

                }

                Console.WriteLine("Your balance: " + balance[0]);

            }

        }



        public static void WithdrawMoney()
        {

            string accountNumber;
            double withdrawAmount;
            double currentBalance;

            Console.WriteLine("Enter your account number: ");
            accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("account not found!");
            }
            else
            {
                Console.WriteLine("Enter withdraw amount: ");
                withdrawAmount = double.Parse(Console.ReadLine());

                if (withdrawAmount < 0)
                {
                    Console.WriteLine("You don't have enugh balance.");
                }
                else
                {
                    balance[0] -= withdrawAmount;
                    Console.WriteLine("Your balance: " + balance[0]);
                }

            }

        }



        public static void ShowBalance()
        {

            string accountNumber;
            double withdrawAmount;
            double currentBalance;

            Console.WriteLine("Enter your account number: ");
            accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("account not found!");
            }
            else
            {
                customerNames[0].Count();
                accountNumbers[0].Count();
                Console.WriteLine("Your balance: " + balance[0]);

            }

        }



        public static void TransferAmount()
        {

            string accountNumber;
            double transferAmount;
            double currentBalance;

            Console.WriteLine("Enter your account number: ");
            accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("account not found!");
            }
            else
            {

                Console.WriteLine("Enter receiver account number: ");
                accountNumber = Console.ReadLine();

                index = accountNumbers.IndexOf(accountNumber);

                if (index == -1)
                {
                    Console.WriteLine("account not found!");
                }
                else
                {
                    Console.WriteLine("Enter amount to transfer: ");
                    transferAmount = double.Parse(Console.ReadLine());

                    if (transferAmount < 0)
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    else
                    {
                        balance[0] -= transferAmount;
                        balance[1] += transferAmount;

                        Console.WriteLine("Your balance: " + balance[0]);

                    }

                }

            }

        }



        public static void ChangeAccountNumber()
        {
            string accountNumber;
            string newAccountNumber;

            Console.WriteLine("Enter your account number: ");
            accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("account not found!");
            }
            else
            {

                Console.WriteLine("Enter your new account number: ");
                newAccountNumber = Console.ReadLine();

                newAccountNumber = accountNumbers.Add();

            }

        }



        public static void ListAllAcounts()
        {
            foreach (string status in customerNames)
            {
                Console.WriteLine(status);
            }

            foreach (string status in accountNumbers)
            {
                Console.WriteLine(status);
            }

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
