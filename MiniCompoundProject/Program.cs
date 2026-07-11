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

                int index = accountNumbers.IndexOf(accountNumber);

                    Console.WriteLine("Enter deposit amount: ");
                    depositAmount = double.Parse(Console.ReadLine());

                    if (depositAmount <= 0)
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    else
                    {

                        Console.WriteLine("Your initial deposit done successfully!");

                        currentBalance = depositAmount;
                        customerNames.Add(customerName);
                        accountNumbers.Add(accountNumber);
                        balance.Add(currentBalance);

                    }
                    
            }

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
                    balance[index] += depositAmount;

                    currentBalance = depositAmount;

                    Console.WriteLine("Your current balance: " + balance[index]);

                }

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

                if (withdrawAmount <= 0  || withdrawAmount > balance[index])
                {
                    Console.WriteLine("You don't have enugh balance.");
                }
                else
                {
                    balance[index] -= withdrawAmount;
                    Console.WriteLine("Withdraw success!");
                    Console.WriteLine("Your current balance: " + balance[index]);
                }

            }

        }



        public static void ShowBalance()
        {

            string accountNumber;

            Console.WriteLine("Enter your account number: ");
            accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("account not found!");
            }
            else
            {
                Console.WriteLine("Your info: ");

                Console.WriteLine(customerNames[index]);
                Console.WriteLine(accountNumbers[index]);
                Console.WriteLine(balance[index]);

                Console.WriteLine("Your current balance " + balance[index] + " OMR ");

            }

        }



        public static void TransferAmount()
        {

            string accountNumber;
            double transferAmount;
            double currentBalance;

            string senderAccount;
            string receiverAccount;

            Console.WriteLine("Enter sender account number: ");
            senderAccount = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(senderAccount);

            if (senderIndex == -1)
            {
                Console.WriteLine("account not found!");
            }
            else
            {

                Console.WriteLine("Enter receiver account number: ");
                receiverAccount = Console.ReadLine();

                int receiverIndex = accountNumbers.IndexOf(receiverAccount);

                if (receiverIndex == -1)
                {
                    Console.WriteLine("account not found!");
                }
                else
                {
                    Console.WriteLine("Enter amount to transfer: ");
                    transferAmount = double.Parse(Console.ReadLine());

                    if (transferAmount <= 0  || transferAmount > balance[senderIndex])
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    else
                    {

                        balance[senderIndex] -= transferAmount;
                        balance[receiverIndex] += transferAmount;

                        Console.WriteLine("Transfer done successfully!");
                        Console.WriteLine("Your current balance: " + balance[senderIndex]);

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

                accountNumbers[index] = newAccountNumber;

                Console.WriteLine("Your account number has changed successfully from: " + accountNumber + " to " + newAccountNumber);

            }

        }



        public static void ListAllAcounts()
        {
          
            for (int i = 0; i < customerNames.Count; i++)
            {
                Console.WriteLine(customerNames[i]);
            }

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine(accountNumbers[i]);
            }

            for (int i = 0; i < balance.Count; i++)
            {
                Console.WriteLine(balance[i]);
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
