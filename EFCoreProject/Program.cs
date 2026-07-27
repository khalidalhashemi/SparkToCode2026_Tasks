using EFCoreProject.Models;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            // Add data on employees table
            //Employee employee1 = new Employee();

            //employee1.empName = "Khalid";
            //employee1.employeeSalary = 600;
            //employee1.employeesSSN = 181920;
            //employee1.employeeAge = 30;

            //context.employees.Add(employee1);
            //context.SaveChanges();


            /******************************************************************************/


            // Case 1: Register new employee

            //Console.WriteLine("Register User.");
            //Employee employee1 = new Employee();

            //Console.WriteLine("Enter Name: ");
            //employee1.empName = Console.ReadLine();

            //Console.WriteLine("Enter Age: ");
            //employee1.employeeAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Salary: ");
            //employee1.employeeSalary = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Employee SSN: ");
            //employee1.employeesSSN = int.Parse(Console.ReadLine());

            //context.employees.Add(employee1);
            //context.SaveChanges();



            // Case 2: delete employee

            Console.WriteLine("Enter employee ID to delete: ");
            int Id = int.Parse(Console.ReadLine());

            Employee employee = context.employees.FirstOrDefault(e => e.employeeID == Id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                context.employees.Remove(employee);
                context.SaveChanges();
                Console.WriteLine("Employee deleted.");

            }
        }
    }
}
