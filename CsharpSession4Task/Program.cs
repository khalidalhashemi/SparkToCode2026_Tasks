namespace CsharpSession4Task
{
    internal class Program
    {

        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome to Csharp Program " + name);
        }
        static void Main(string[] args)
        {

            // Task 1: Personalized Welcome Function

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);

        }
    }
}
