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

            //string show;
            //string history;

            //Console.WriteLine("Enter first website: ");
            //string url1 = Console.ReadLine();

            //Console.WriteLine("Enter second website: ");
            //string url2 = Console.ReadLine();

            //Console.WriteLine("Enter third website: ");
            //string url3 = Console.ReadLine();

            //Stack<string> browserHistory = new Stack<string>();
            //browserHistory.Push(url1);
            //browserHistory.Push(url2);
            //browserHistory.Push(url3);

            //show = browserHistory.Peek();

            //history = browserHistory.Pop();

            //Console.WriteLine("Your browsing history: ");

            //foreach (string url in browserHistory)
            //{
            //    Console.WriteLine(url);
            //}

            //////////////////////////////////////////////////////////////
            ///


            // Task 4: Customer Service Queue

            //Console.WriteLine("Enter first customer name: ");
            //string customer1 = Console.ReadLine();

            //Console.WriteLine("Enter second customer name: ");
            //string customer2 = Console.ReadLine();

            //Console.WriteLine("Enter third customer name: ");
            //string customer3 = Console.ReadLine();


            //Queue<string> customerNumber = new Queue<string>();
            //customerNumber.Enqueue(customer1);
            //customerNumber.Enqueue(customer2);
            //customerNumber.Enqueue(customer3);


            //string firstCustomer = customerNumber.Peek();

            //string firstCustomerOut = customerNumber.Dequeue();

            //Console.WriteLine("Customer service queue: ");

            //foreach (string service in customerNumber)
            //{
            //    Console.WriteLine(service);
            //}

            //////////////////////////////////////////////////////////////
            ///


            // Task 5: Array Grade Range:

            int[] studentGrade = new int[5];
            studentGrade[0] = 0;
            studentGrade[1] = 0;
            studentGrade[2] = 0;
            studentGrade[3] = 0;
            studentGrade[4] = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your grades: ");
                int grades = int.Parse(Console.ReadLine());

                studentGrade[i] = grades;

            }

            Array.Sort(studentGrade);

            Console.WriteLine("Your Grades Sorts: ");
            Console.WriteLine(string.Join(", ", studentGrade));

            double averageGrade = studentGrade.Average();
            Console.WriteLine("Your grades average: " +  averageGrade);





        }
    }
}
