namespace FundamentalTask1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Personal Info Card

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Height (in meters): ");
            double height = double.Parse(Console.ReadLine());

            bool Student = age <= 18;

            Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", isStudent: " + Student);

        }
    }
}
