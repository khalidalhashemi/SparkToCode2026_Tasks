namespace CsharpSession4Task
{
    internal class Program
    {

        //public static void PrintWelcome(string name)
        //{
        //    Console.WriteLine("Welcome to Csharp Program " + name);
        //}

        public static int Square(int number)
        {
            int result;

            result = (int)Math.Sqrt(number);

            return  result;
        }

        static void Main(string[] args)
        {

            // Task 1: Personalized Welcome Function

            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();

            //PrintWelcome(name);

            /////////////////////////////////////////////////////////
            ///


            // Task 2: Square Number Function

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result;

            result = Square(number);

            Console.WriteLine("Your result: " + result);



        }
    }
}
