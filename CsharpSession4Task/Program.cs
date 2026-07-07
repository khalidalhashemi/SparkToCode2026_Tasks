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

        public static void CountDown(int number)
        {
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static double CalculateArea(double side)
        {
            double Area;

            Area = side * side;

            return Area;
        }

        public static double CalculateArea(double length, double width)
        {
            double Area = length * width;

            return Area;
        }

        public static double AddNumbers(double num1, double num2)
        {
            double result = num1 + num2;

            return result;
        }

        public static double SubNumbers(double num1, double num2)
        {
            double result = num1 - num2;

            return result;
        }

        public static double MultiplyNumbers(double num1, double num2)
        {
            double result = num1 * num2;

            return result;
        }

        public static double DivideNumbers(double num1, double num2)
        {

            double result;

            result = num1 / num2;

            if (num2 == 0)
            {
                Console.WriteLine("Error, cannot divided by zero.");
            }

            return result;
        }

        public static void DispalyResult(string operationName, double result)
        {
            Console.WriteLine("Your operation: " + operationName + " With result: " + result);
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

            //string FinalGrade;

            //Console.WriteLine("Enter your grade to classify it: ");
            //int Grade = int.Parse(Console.ReadLine());

            //FinalGrade = GetGradeLetter(Grade);

            //Console.WriteLine("Your Grade is: " + FinalGrade);

            /////////////////////////////////////////////////////////
            ///


            // Task 8: Countdown Function

            //Console.WriteLine("Enter a number to start countdown from: ");
            //int number = int.Parse(Console.ReadLine());

            //CountDown(number);

            /////////////////////////////////////////////////////////
            ///


            // Task 9: Overloaded Multiply Function

            //int result1;
            //double result2;
            //int result3;

            //Console.WriteLine("Enter first integer number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second integer number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter third integer number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //result1 = Multiply(num1, num2);

            //result3 = Multiply(num1, num2, num3);


            //Console.WriteLine("Enter first double number: ");
            //double Dobnum1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second double number: ");
            //double Dobnum2 = double.Parse(Console.ReadLine());

            //result2 = Multiply(Dobnum1, Dobnum2);


            //Console.WriteLine("Result takes two integers: " + result1);

            //Console.WriteLine("Result takes two double: " + result2);

            //Console.WriteLine("Result takes three integers: " + result3);

            /////////////////////////////////////////////////////////
            ///


            // Task 10: Overloaded Area Calculator

            //double AreaOfSquare;
            //double AreaOfRectangle;

            //Console.WriteLine("Choose which shape do you want to calculate its Area: ");
            //Console.WriteLine("1. Square");
            //Console.WriteLine("2. Rectangle");
            //int userChoise = int.Parse(Console.ReadLine());

            //switch (userChoise)
            //{
            //    case 1:
            //        Console.WriteLine("You choosed Square.");

            //        Console.WriteLine("Enter the side of square: ");
            //        double side = double.Parse(Console.ReadLine());

            //        AreaOfSquare = CalculateArea(side);

            //        Console.WriteLine("The area of square is: " + AreaOfSquare);

            //        break;

            //    case 2:
            //        Console.WriteLine("You choosed Rectangle.");

            //        Console.WriteLine("Enter the length of rectangle: ");
            //        double length = double.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter the width of rectangle: ");
            //        double width = double.Parse(Console.ReadLine());

            //        AreaOfRectangle = CalculateArea(length, width);

            //        Console.WriteLine("The area of rctangle is: " + AreaOfRectangle);

            //        break;

            //    default:
            //        Console.WriteLine("Invalid choise!");
            //        break;
            //}

            /////////////////////////////////////////////////////////
            ///


            // Task 11:  Function-Based Calculator

            double addResult;
            double subResult;
            double mulResult;
            double divResult;
            bool exit = false;

            do
            {
                Console.WriteLine("Choose your operation: ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Divition");
                int userChoise = int.Parse(Console.ReadLine());

                switch (userChoise)
                {
                    case 1:
                        Console.WriteLine("You choosed Addition.");

                        Console.WriteLine("Enter first number: ");
                        double addNum1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter second number: ");
                        double addNum2 = double.Parse(Console.ReadLine());

                        addResult = AddNumbers(addNum1, addNum2);

                        Console.WriteLine("Addition = " + addResult);

                        break;

                    case 2:
                        Console.WriteLine("You choosed Subtraction.");

                        Console.WriteLine("Enter first number: ");
                        double subNum1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter second number: ");
                        double subNum2 = double.Parse(Console.ReadLine());

                        subResult = SubNumbers(subNum1, subNum2);

                        Console.WriteLine("Subtraction = " + subResult);

                        break;

                    case 3:
                        Console.WriteLine("You choosed Multiplication.");

                        Console.WriteLine("Enter first number: ");
                        double mulNum1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter second number: ");
                        double mulNum2 = double.Parse(Console.ReadLine());

                        mulResult = MultiplyNumbers(mulNum1, mulNum2);

                        Console.WriteLine("Multiplication = " + mulResult);

                        break;

                    case 4:
                        Console.WriteLine("You choosed Divition.");

                        Console.WriteLine("Enter first number: ");
                        double divNum1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter second number: ");
                        double divNum2 = double.Parse(Console.ReadLine());

                        divResult = DivideNumbers(divNum1, divNum2);

                        Console.WriteLine("Divition = " + divResult);

                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        
                        break;
                }

                Console.WriteLine("Do you want to exit?");
                string exitDecision = Console.ReadLine();

                if (exitDecision == "yes")
                {
                    exit = false;
                }
                else
                {
                    exit = true;
                }
            }
            while (exit);

        }
    }
}
