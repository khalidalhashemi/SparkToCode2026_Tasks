namespace LoopErrorHandlingSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop & Error Handling Task

            // Task 1: Countdown Timer

            int CountDownNum = 0;
            int countDown;

            Console.WriteLine("Enter a number to countdown from: ");
            CountDownNum = int.Parse(Console.ReadLine());

            for(countDown = CountDownNum; countDown >= 1; countDown--)
            {
                Console.WriteLine(countDown);
            }

            Console.WriteLine("Liftoff!");
            
            ////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
