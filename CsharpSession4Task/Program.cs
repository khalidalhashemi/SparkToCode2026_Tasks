namespace CsharpSession4Task
{
    internal class Program
    {

        //public static void PrintWelcome(string name)
        //{
        //    Console.WriteLine("Welcome to Csharp Program " + name);
        //}

        //public static int Square(int number)
        //{
        //    int result;

        //    result = (int)Math.Sqrt(number);

        //    return  result;
        //}

        public static double TempConversion(double Celsius)
        {
            double Fahrenheit;

            Fahrenheit = (Celsius * 9 / 5) + 32;

            return Fahrenheit;
        }

        public static void MenuDisplay()
        {
            Console.WriteLine("Main Menu: ");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Help");
            Console.WriteLine("3. Exit");
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

            //Console.WriteLine("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int result;

            //result = Square(number);

            //Console.WriteLine("Your result: " + result);

            /////////////////////////////////////////////////////////
            ///


            // Task 3: Celsius to Fahrenheit Function

            //double Fahrenheit;

            //Console.WriteLine("Enter temperature in Celsius to converte it to Fahrenheit: ");
            //double Celsius = double.Parse(Console.ReadLine());

            //Fahrenheit = TempConversion(Celsius);

            //Console.WriteLine("Tempareture in Fahrenheit: " + Fahrenheit + " F");

            /////////////////////////////////////////////////////////
            ///


            // Task 4: Fixed Menu Display Function

            Console.WriteLine("Here is the menu: ");
            MenuDisplay();




        }
    }
}
