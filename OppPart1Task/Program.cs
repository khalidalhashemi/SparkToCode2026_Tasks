using System.Security.Principal;

namespace OppPart1Task
{

    public class BankAccount
    {
        // Properties
        public int AccountNumber { get; set; }

        public string HolderName { get; set; }

        public double Balance { get; set; }


        // Methods

        public void Deposite(double amount)
        {

            Balance += amount;

            SendEmail();

        }

        public void Withdraw(double amount)
        {

            if (Balance <= 0)
            {
                Console.WriteLine("You don't have enough amount.");
            }
            else
            {
                Balance -= amount;

                SendEmail();
            }

        }

        public double CheckBalance()
        {

            PrintInformation();

            return Balance;

        }

        private void PrintInformation()
        {

            Console.WriteLine(HolderName);
            Console.WriteLine(Balance);

        }

        private void SendEmail()
        {

            Console.WriteLine("To " /*+ StudentEmail*/);
            Console.WriteLine("Hello " + HolderName);
            Console.WriteLine("Your operation has been done successfully!");

        }

    }



    public class Student
    {
        // Properties
        public int Grade { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        private string Email { get; set; }

        int Age { get; set; }


        // Method

        public void Register(string email)
        {

            Console.WriteLine("Your registration done successfully! Your info: ");
            Console.WriteLine(Name);
            Console.WriteLine(Grade);
            Console.WriteLine(Address);
            Console.WriteLine(Age);
            Console.WriteLine(Email);

        }

        private void SendEmail()
        {

            Console.WriteLine("To " + Name);
            Console.WriteLine("Your completed your registration!");

        }

    }



    public class Product
    {
        // Properties
        public string ProductName { get; set; }

        public double Price { get; set; }

        public int StockQuantity { get; set; }


        // Methods

        public void Sell(int quantity)
        {
            int newStockQuantity;

            if (StockQuantity >= quantity)
            {
                newStockQuantity = StockQuantity - quantity;
                Console.WriteLine("Your current quantity: " + newStockQuantity);

                LogTransaction();
            }
            else
            {
                StockQuantity = quantity;
                Console.WriteLine("Not enough stock.");
            }

        }

        public void Restock(int quantity)
        {

            StockQuantity += quantity;

            LogTransaction();

        }

        public double GetInventoryValue()
        {

            PrintDetails();

            return Price * StockQuantity;

        }

        private void PrintDetails()
        {

            Console.WriteLine(ProductName);
            Console.WriteLine(Price);
            Console.WriteLine(StockQuantity);

        }

        private void LogTransaction()
        {

            Console.WriteLine("Transaction logged.");

        }

    }



    public class Program
    {

        static BankAccount account1 = new BankAccount { AccountNumber = 92691313, HolderName = "Khalid", Balance = 120 };
        static BankAccount account2 = new BankAccount { AccountNumber = 99131216, HolderName = "Mohammed", Balance = 60 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65, };
        static Student student2 = new Student { Name = "Ahmed", Address = "Salalah", Grade = 70, };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            
        }

        // Choose an Account, Student and Producr 

        static BankAccount ChooseAccount()
        {
            Console.WriteLine("Choose an account 1 or 2: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                return account1;
            }
            else
            {
                Console.WriteLine("invalid number");
            }
            return account2;

        }

        static Student ChooseStudent()
        {
            Console.WriteLine("Choose a student 1 or 2: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                return student1;
            }
            else
            {
                return student2;
            }

        }

        static Product ChooseProduct()
        {
            Console.WriteLine("Choose a student 1 or 2: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                return product1;
            }
            else
            {
                return product2;
            }

        }

        // Main Functions

        // Case 1: View Account Details

        static void ViewAccountDetails()
        {
            BankAccount chooseAccount = ChooseAccount();
            double balance = chooseAccount.CheckBalance();
            Console.WriteLine("Returned balance: " + balance);
        }



        // Case 2: Update Student Address

        static void UpdateStudentAddress()
        {
            Student chooseStudent = ChooseStudent();

            Console.WriteLine("Update the student address: ");
            string newStudentAddress = Console.ReadLine();

            chooseStudent.Address = newStudentAddress;

            Console.WriteLine("Address Updated to: " + newStudentAddress);
        }



        // Case 3: Make a Deposite

        static void MakeDeposite()
        {
            BankAccount chooseAccount = ChooseAccount();

            Console.WriteLine("Enter deposite amount: ");
            double amount = double.Parse(Console.ReadLine());

            ChooseAccount().Deposite(amount);

            ChooseAccount().CheckBalance();
        }



        // Case 4: Make Withdraw

        static void MakeWithdraw()
        {
            BankAccount chooseAccount = ChooseAccount();

            Console.WriteLine("Enter withdraw amount: ");
            double amount = double.Parse(Console.ReadLine());

            ChooseAccount().Withdraw(amount);

            ChooseAccount().CheckBalance();
        }



        // Case 5: View Product Details

        static void ViewProductDetails()
        {
            Product chooseProduct = ChooseProduct();

            ChooseProduct().GetInventoryValue();
        }


    }
}
