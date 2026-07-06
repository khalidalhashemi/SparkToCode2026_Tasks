using System.Runtime.Intrinsics.X86;

namespace Task3Buil_inFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Absolute Difference

            //float sub;

            //Console.WriteLine("Enter first number: ");
            //float num1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //float num2 = float.Parse(Console.ReadLine());

            //sub = num2 - num1;

            //int Absolute = (int)Math.Abs(sub);

            //Console.WriteLine("The result is: " + Absolute);

            ///////////////////////////////////////////////////////////////////////////
            ///


            // Task 2: Power & Root Explorer

            int number;

            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            double Power = Math.Pow(number, 2);

            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Your power of 2 is: " + Power);
            Console.WriteLine("Your Square Root is: " + squareRoot);

        }
    }
}
