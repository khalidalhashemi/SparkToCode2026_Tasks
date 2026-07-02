namespace FundamentalTask1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Personal Info Card

            //Console.Write("Enter Your Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Enter Your Height (in meters): ");
            //double height = double.Parse(Console.ReadLine());

            //bool Student = age <= 18;

            //Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", isStudent: " + Student);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 2: Rectangle Calculator

            //Console.Write("Enter the length of the rectangle: ");
            //float length = float.Parse(Console.ReadLine());

            //Console.Write("Enter the width of the rectangle: ");
            //float width = float.Parse(Console.ReadLine());

            //float Area = length * width;
            //float Perimeter = 2 * (length + width);

            //Console.WriteLine("Area of the rectangle: " + Area);
            //Console.WriteLine("Perimeter of the rectangle: " + Perimeter);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 3: Even or Odd Checker

            //Console.Write("Enter a number to check if it's even or odd: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine(number + " is even number.");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is odd number.");
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 4: Voting Eligibility

            //Console.WriteLine("Enter your age to check voting eligibility: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a valid national ID? (yes/no)");
            //string hasId = Console.ReadLine();

            //bool ValidID = hasId.ToLower() == "yes";

            //if (age >= 18 && ValidID)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 5: Grade Letter Lookup

            //Console.WriteLine("Enter the number corresponding to your grade: ");
            //Console.WriteLine("1. A");
            //Console.WriteLine("2. B");
            //Console.WriteLine("3. C");
            //Console.WriteLine("4. D");
            //Console.WriteLine("5. F");

            //int grade = int.Parse(Console.ReadLine());

            //switch (grade)
            //{
            //    case 1:
            //        Console.WriteLine("Your grade is A = Exellent.");
            //        break;

            //    case 2:
            //        Console.WriteLine("Your grade is B = Very Good.");
            //        break;

            //    case 3:
            //        Console.WriteLine("Your grade is C = Good.");
            //        break;

            //    case 4:
            //        Console.WriteLine("Your grade is D = Pass.");
            //        break;

            //    case 5:
            //        Console.WriteLine("Your grade is F = Fail.");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid grade!");
            //        break;
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 6: Temperature Converter

            //Console.WriteLine("Enter the temperature in Celsius: ");
            //float Celsius = float.Parse(Console.ReadLine());

            //if (Celsius < 10)
            //{
            //    Console.WriteLine("The weather is Cold.");
            //}
            //else if (Celsius >= 10 && Celsius < 30)
            //{
            //    Console.WriteLine("The weather is Mild.");
            //}
            //else
            //{
            //    Console.WriteLine("The weather is Hot.");
            //}

            //float Fahrenheit = (Celsius * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit: " + Fahrenheit);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            // Task 7: Movie Ticket Pricing

            Console.WriteLine("Enter your age to check movie ticket pricing: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("You are Children, and your ticket price = 2.000 OMR.");
            }
            else if (age >= 13 && age <= 59)
            {
                Console.WriteLine("You are Adults, and your ticket price = 5.000 OMR.");
            }
            else
            {
                Console.WriteLine("You are Senior, and your ticket price = 3.000 OMR.");
            }



        }
    }
}
