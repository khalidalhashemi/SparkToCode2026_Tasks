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
        static void Main(string[] args)
        {
            
        }
    }
}
