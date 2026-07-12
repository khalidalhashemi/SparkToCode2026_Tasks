namespace OppPart1Task
{

    public class BankAccount
    {
        public int AccountNumber { get; set; }

        public string HolderName { get; set; }

        public double Balance { get; set; }

    }


    public class Student
    {
        public int Grade { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        private string Email { get; set; }

        int Age { get; set; }
    }


    public class Product
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public int StackQuantity { get; set; }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
