using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Transactions;

namespace OppPart1Task
{

    public class BankAccount
    {
        private bool isOverDraw;

        public bool isOverDrawn
        {
            get
            {
                return (Balance < 0);
            }
        }

        // Properties
        public int AccountNumber { get; set; }

        public string HolderName { get; set; }

        public double Balance { get; set; }





        public BankAccount()
        {

        }
        public BankAccount(int  accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }




        // Methods

        public void Deposite(double amount)
        {

            Balance += amount;

            SendEmail();

        }

        public void Withdraw(double amount)
        {

            if (Balance < amount)
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
        private int SecurityPIN;

        public int securityPIN
        {
            set
            {
                if (value >= 1000 && value <= 9999)
                {
                    SecurityPIN = value;
                }
                else
                {
                    Console.WriteLine("PIN must contains 4 digits only. Please try again.");
                }
            }
        }


        private static int StudentCount;

        public Student()
        {
            StudentCount++;
        }

        public static int GetStudentCount()
        {
            return StudentCount;
        }

        // Properties
        public int Grade { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        private string Email { get; set; }

        int Age { get; set; }


        // Method

        public void Register(string email)
        {

            Email = email;

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

            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposite(); break;
                    case 4: MakeWithdraw(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareTwoAccountBalance(); break;
                    case 8: RestockProductAndStockLevel(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenueCalculation(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: NewBankAccount(); break;
                    case 17: TotalStudent(); break;
                    case 18: CheckOverDrawn(); break;
                    case 19: CreateSecurityPIN(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();

            }

        }

        // Choose an Account, Student and Producr //

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

            chooseAccount.Deposite(amount);

            chooseAccount.CheckBalance();
        }



        // Case 4: Make Withdraw

        static void MakeWithdraw()
        {
            BankAccount chooseAccount = ChooseAccount();

            Console.WriteLine("Enter withdraw amount: ");
            double amount = double.Parse(Console.ReadLine());

            chooseAccount.Withdraw(amount);

            chooseAccount.CheckBalance();
        }



        // Case 5: View Product Details

        static void ViewProductDetails()
        {
            Product chooseProduct = ChooseProduct();

            chooseProduct.GetInventoryValue();
        }



        // Case 6: Register a Student

        static void RegisterStudent()
        {
            Student chooseStudent = ChooseStudent();

            Console.WriteLine("Enter your email: ");
            string userEmail = Console.ReadLine();

            chooseStudent.Register(userEmail);

            Console.WriteLine("Registration Compeleted!");
        }



        // Case 7: Compare Two Account Balances

        static void CompareTwoAccountBalance()
        {

            if (account1.Balance ==  account2.Balance)
            {
                Console.WriteLine("Both accounts hold the same amount of money.");
            }
            else if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + " Holds more amount fo money.");
            }
            else
            {
                Console.WriteLine(account2.HolderName + " Holds more amount fo money.");
            }
        }



        // Case 8: Restock Product & Stock Level Check

        static void RestockProductAndStockLevel()
        {
            Product chooseProduct = ChooseProduct();

            Console.WriteLine("Enter additional quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            chooseProduct.Restock(quantity);

            if (chooseProduct.StockQuantity < 10)
            {
                Console.WriteLine("Stock level is Low.");
            }
            else if (chooseProduct.StockQuantity >= 10 && chooseProduct.StockQuantity <= 49)
            {
                Console.WriteLine("Stock level is Moderate.");
            }
            else
            {
                Console.WriteLine("Stock level is Well");
            }
        }



        // Case 9: Transfer Between Accounts

        static void TransferBetweenAccounts()
        {

            BankAccount source = null;
            BankAccount destination = null;
            
            Console.WriteLine("Choose the source account (1 or 2) ");
            int userChoise = int.Parse(Console.ReadLine());

            if (userChoise == 1)
            {
                source = account1;
            }
            else if (userChoise == 2)
            {
                source = account2;
            }
            else
            {
                Console.WriteLine("Invalid account.");
            }

            Console.WriteLine("Choose the destination account (1 or 2) ");
            int userChoise2 = int.Parse(Console.ReadLine());

            if (userChoise2 == 1)
            {
                destination = account1;
            }
            else if (userChoise2 == 2)
            {
                destination = account2;
            }
            else
            {
                Console.WriteLine("Invalid account.");
            }

            Console.WriteLine("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (source == destination)
            {
                Console.WriteLine("source and destination cannot be the same account.");
                return;
            }
            else if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposite(amount);

                source.CheckBalance();
                destination.CheckBalance();
            }
            else
            {
                Console.WriteLine("Not enough balance.");

                source.CheckBalance();
                destination.CheckBalance();
            }

        }



        // Case 10: Update Student Grade (Validated)

        static void UpdateStudentGrade()
        {
            Student userStudent = ChooseStudent();

            Console.WriteLine("Enter a new grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 0 && grade <= 100)
            {
                userStudent.Grade = grade;
                Console.WriteLine("Grade has been changed!");
            }
            else
            {
                Console.WriteLine("Invalid grade.");
                Console.WriteLine("No change made.");
            }
        }



        // Case 11: Student Report Card

        static void StudentReportCard()
        {
            Student studentReport = ChooseStudent();

            Console.WriteLine("Student report card of " + studentReport);
            Console.WriteLine(studentReport.Name);
            Console.WriteLine(studentReport.Address);
            Console.WriteLine(studentReport.Grade);

            if (studentReport.Grade >= 60)
            {
                Console.WriteLine(studentReport.Name + " Pass.");
            }
            else
            {
                Console.WriteLine(studentReport.Name + " Fail");
            }
        }



        // Case 12: Account Health Status

        static void AccountHealthStatus()
        {
            BankAccount bankStatus = ChooseAccount();

            if (bankStatus.Balance < 50)
            {
                Console.WriteLine("Low Balance.");
            }
            else if (bankStatus.Balance >= 50 && bankStatus.Balance <= 1000)
            {
                Console.WriteLine("Healthy Balance.");
            }
            else if (bankStatus.Balance > 1000)
            {
                Console.WriteLine("Premium Balance.");
            }
        }



        // Case 13: Bulk Sale With Revenue Calculation

        static void BulkSaleWithRevenueCalculation()
        {
            Product userProduct = ChooseProduct();

            Console.WriteLine("Enter quantity to sale: ");
            int quantity = int.Parse(Console.ReadLine());

            if (userProduct.StockQuantity >= quantity)
            {
                userProduct.Sell(quantity);
                double revenue = userProduct.Price * quantity;

                Console.WriteLine("Revenue is: " + revenue);
            }
            else
            {
                Console.WriteLine("Not enough stock.");
                int missingQuantity = quantity - userProduct.StockQuantity;
                Console.WriteLine("Missing quantities: " + missingQuantity);
            }
        }



        // Case 14: Scholarship Eligibility Check

        static void ScholarshipEligibilityCheck()
        {
            Console.WriteLine("Choose one student: ");
            Student userStudent = ChooseStudent();

            Console.WriteLine("Choose one bank account: ");
            BankAccount userAccount = ChooseAccount();

            if (userStudent.Grade >= 80 && userAccount.Balance >= 100)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Inligible");

                if (userStudent.Grade < 80)
                {
                    Console.WriteLine("Grade must be 80 or above.");
                }
                
                if (userAccount.Balance < 100)
                {
                    Console.WriteLine("Balance must be 100 or above.");
                }
            }
        }



        // Case 15: Full Balance Top-Up Flow

        static void FullBalanceTopUpFlow()
        {
            BankAccount userAccount = ChooseAccount();

            userAccount.CheckBalance();

            if (userAccount.Balance < 50)
            {
                double TopUp = 100 - userAccount.Balance;

                Console.WriteLine("Balance befor Top-Up: " + userAccount.Balance);

                userAccount.Deposite(TopUp);

                Console.WriteLine("Balance after Top-Up: " + userAccount.Balance);
            } 
            else if (userAccount.Balance >= 50)
            {
                Console.WriteLine("No Top-Up needed.");
            }
        }



        // Case 16: Quick Account Opening [Parameterized Constructor]

        static void NewBankAccount()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your account Number: ");
            int userAccountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Make your fitrt deposit: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount newAccount = new BankAccount (userAccountNumber, userName, balance);

            Console.WriteLine("Your details: ");
            Console.WriteLine("Holder name: " + userName);
            Console.WriteLine("Account number: " + userAccountNumber);
            Console.WriteLine("Balance: " + balance);
        }



        // Case 17: Total Students Counter [Static Fields & Methods]

        static void TotalStudent()
        {
            Console.WriteLine("Total number of student is: " + Student.GetStudentCount());
        }



        // Case 18: Overdrawn Account Check [Read-Only Property]

        static void CheckOverDrawn()
        {
            BankAccount userAccount = ChooseAccount();

            if (userAccount.isOverDrawn)
            {
                Console.WriteLine("This account is overdrawn.");
            }
            else
            {
                Console.WriteLine("This account is not overdrawn.");
            }
        }



        // Case 19: Set Student Security PIN [Write-Only Property]

        static void CreateSecurityPIN()
        {
            Student userStudent = ChooseStudent();

            Console.WriteLine("Enter your security PIN: ");
            int PIN = int.Parse(Console.ReadLine());

            if (PIN >= 1000 && PIN <= 9999)
            {
                userStudent.securityPIN = PIN;
                Console.WriteLine("PIN has been set successfully!");
            }
            else
            {
                Console.WriteLine("PIN not created. please try again.");
            }
        }



    }
}
