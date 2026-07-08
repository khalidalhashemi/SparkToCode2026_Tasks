namespace SolutionTask5Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1: Fixed Grades Array

            //int[] studentGrade = new int[5];
            //studentGrade[0] = 0;
            //studentGrade[1] = 0;
            //studentGrade[2] = 0;
            //studentGrade[3] = 0;
            //studentGrade[4] = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter your grades: ");
            //    int grade = int.Parse(Console.ReadLine());

            //    studentGrade[i] = grade;

            //}

            //Console.WriteLine("Your grades: ");
            //foreach (int grade in studentGrade)
            //{
            //    Console.WriteLine(grade);
            //}

            //////////////////////////////////////////////////////////////
            ///


            // Task 2:  Dynamic To-Do List

            //List<string> ToDoList = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter todays tasks: ");
            //    string taskName = Console.ReadLine();

            //    ToDoList.Add(taskName);

            //}

            //foreach (string taskName in ToDoList)
            //{
            //    Console.WriteLine("Your tasks for today: " + taskName);
            //}

            //////////////////////////////////////////////////////////////
            ///


            // Task 3: Browsing History Stack

            string show;
            string history;

            Console.WriteLine("Enter first website: ");
            string url1 = Console.ReadLine();

            Console.WriteLine("Enter second website: ");
            string url2 = Console.ReadLine();

            Console.WriteLine("Enter third website: ");
            string url3 = Console.ReadLine();

            Stack<string> browserHistory = new Stack<string>();
            browserHistory.Push(url1);
            browserHistory.Push(url2);
            browserHistory.Push(url3);

            show = browserHistory.Peek();

            history = browserHistory.Pop();

            Console.WriteLine("Your browsing history: ");

            foreach (string url in browserHistory)
            {
                Console.WriteLine(url);
            }

            //////////////////////////////////////////////////////////////
            ///


   




        }
    }
}
