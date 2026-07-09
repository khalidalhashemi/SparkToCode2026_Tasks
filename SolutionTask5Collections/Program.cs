using System.Transactions;

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

            //int[] studentGrade = new int[5];
            //studentGrade[0] = 0;
            //studentGrade[1] = 0;
            //studentGrade[2] = 0;
            //studentGrade[3] = 0;
            //studentGrade[4] = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter your grades: ");
            //    int grades = int.Parse(Console.ReadLine());

            //    studentGrade[i] = grades;

            //}

            //Array.Sort(studentGrade);

            //Console.WriteLine("Your Grades Sorts: ");
            //Console.WriteLine(string.Join(", ", studentGrade));

            //double averageGrade = studentGrade.Average();
            //Console.WriteLine("Your grades average: " +  averageGrade);

            //////////////////////////////////////////////////////////////
            ///


            // Task 6: Filtered Shopping List

            //bool Exit = false;
            //string item;

            //List<string> shoppingList = new List<string>();

            //while (Exit == false)
            //{
            //    Console.WriteLine("Add item to the list: ");
            //    item = Console.ReadLine();


            //    if (item == "done")
            //    {
            //        Console.WriteLine("Do you whant to remove an item? (true/false)");
            //        bool removeItem = bool.Parse(Console.ReadLine());

            //        if (removeItem == true)
            //        {
            //            Console.WriteLine("Enter the item you want to remove: ");
            //            item = Console.ReadLine();

            //            shoppingList.Remove(item);

            //            Exit = true;
            //        }
            //        else
            //        {
            //            Exit = true;
            //        }


            //    }
            //    else
            //    {
            //        shoppingList.Add(item);
            //    }


            //}

            //Console.WriteLine("Your shopping cart has: " +  shoppingList.Count + " items.");

            //foreach (string shoppingCart in shoppingList)
            //{
            //    Console.WriteLine(shoppingCart);
            //}

            //////////////////////////////////////////////////////////////
            ///


            // Task 7: High Score Podium

            //Console.WriteLine("Enter game score 1:");
            //int score1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter game score 2:");
            //int score2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter game score 3:");
            //int score3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter game score 4:");
            //int score4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter game score 5:");
            //int score5 = int.Parse(Console.ReadLine());

            //List<int> gameScore = new List<int>();
            //gameScore.Add(score1);
            //gameScore.Add(score2);
            //gameScore.Add(score3);
            //gameScore.Add(score4);
            //gameScore.Add(score5);

            //gameScore.Sort();

            //gameScore.Reverse();

            //foreach (int place in gameScore)
            //{
            //    Console.WriteLine(place);
            //}


            //int firstplace = gameScore[0];

            //int secondplace = gameScore[1];

            //int thirdplace = gameScore[2];

            //Console.WriteLine("1st place: " + firstplace);
            //Console.WriteLine("2nd place: " + secondplace);
            //Console.WriteLine("3rd place: " + thirdplace);

            //////////////////////////////////////////////////////////////
            ///


            // Task 8: Undo Last Action

            bool Exit = false;

            Stack<string> actionTrack = new Stack<string>();

            while (Exit == false)
            {
                Console.WriteLine("Type an action: ");
                string action = Console.ReadLine();

                if (action == "stop")
                {
                    Console.WriteLine("write undo to move back: ");
                    string removeAction = Console.ReadLine();

                    if (removeAction == "undo")
                    {
                        actionTrack.Pop();

                        Exit = true;

                    }
                    else
                    {
                        Exit = true;
                    }

                }
                else
                {
                    actionTrack.Push(action);
                }

            }

            int show = actionTrack.Count;

            foreach (string action in actionTrack)
            {
                Console.WriteLine(action);
            }



        }
    }
}
