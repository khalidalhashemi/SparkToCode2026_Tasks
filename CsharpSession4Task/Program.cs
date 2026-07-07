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

        public static bool isEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double RectArea(double length, double width)
        {
            double Area;

            Area = length * width;

            return Area;
        }

        public static double RectPerimeter(double length, double width)
        {
            double Perimeter;

            Perimeter = 2 * (length + width);

            return Perimeter;
        }

        public static string GetGradeLetter(int Grade)
        {

            if (Grade >= 90)
            {
                return "A";
            }
            else if (Grade <= 89 && Grade >= 70)
            {
                return "B";
            }
            else if (Grade <= 69 && Grade >=60 )
            {
                return "C";
            }
            else if (Grade <= 50 && Grade >= 40)
            {
                return "D";
            }
            else
            {
                return "F";
            }
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

            //Console.WriteLine("Here is the menu: ");
            //MenuDisplay();

            /////////////////////////////////////////////////////////
            ///


            // Task 5: Even or Odd Function  

            //Console.WriteLine("Enter a number to check if it is Odd or Even: ");
            //int number = int.Parse(Console.ReadLine());

            //bool result = isEven(number);

            //if (result == true)
            //{
            //    Console.WriteLine("Even.");
            //}
            //else
            //{
            //    Console.WriteLine("Odd.");
            //}

            /////////////////////////////////////////////////////////
            ///


            // Task 6: Rectangle Area & Perimeter Functions

            //double Area;
            //double Perimeter;

            //Console.WriteLine("Enter length of Rectagle to calculate Area: ");
            //double areaLength = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter width of Rectagle to calculate Area: ");
            //double areaWidth = double.Parse(Console.ReadLine());

            //Area = RectArea(areaLength, areaWidth);

            //Console.WriteLine("The Area of Rectangle is: " + Area);


            //Console.WriteLine("Enter length of Rectagle to calculate Perimeter: ");
            //double perimeterLength = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter width of Rectagle to calculate Perimeter: ");
            //double perimeterWidth = double.Parse(Console.ReadLine());

            //Perimeter = RectPerimeter(perimeterLength, perimeterWidth);

            //Console.WriteLine("The Perimeter of Rectangle is :" + Perimeter);

            /////////////////////////////////////////////////////////
            ///


            // Task 7: Grade Letter Function

            string FinalGrade;

            Console.WriteLine("Enter your grade to classify it: ");
            int Grade = int.Parse(Console.ReadLine());

            FinalGrade = GetGradeLetter(Grade);

            Console.WriteLine("Your Grade is: " + FinalGrade);





        }
    }
}
