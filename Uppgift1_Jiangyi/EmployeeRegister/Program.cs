
using System.Xml.Linq;

namespace Uppgift_Jiang.Employee
{
    internal class Program
    {

        private static List<EmployeeRegister.Empolyee> employees = new List<EmployeeRegister.Empolyee>();
        static void Main(string[] args)
        {
            //ask for employee input
            AddSomeEmployees();
            ProgramOptions();

        }
        public static void AddSomeEmployees()
        {
            employees.Add(new EmployeeRegister.Empolyee("Jiang", 20000));
            employees.Add(new EmployeeRegister.Empolyee("Fiona", 25000));
            employees.Add(new EmployeeRegister.Empolyee("Eva", 18000));
        }

        public static void ProgramOptions()
        {

            Console.WriteLine($"What whould you like to do today" +
                $"\n" + "1: Resgiter new employee" +
                  $"\n" + "2: Print out all employee" +
                    $"\n" + "3: Close app");
            string choice = Console.ReadLine() ?? "";

            int number;
            //saft convert string to int
            if (int.TryParse(choice, out number))
            {
                if (number >= 1 && number <= 3)
                {
                    switch (number)
                    {
                        case 1:
                            SignUp();
                            break;
                        case 2:
                            ShowUp();
                            break;
                        case 3:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose between 1-3");
                }
            }
            else
            {
                Console.WriteLine("Input is not a valid integer");
            }
        }//end of Program Options
        public static void SignUp()
        {
            Console.WriteLine("Name of the employee");
            string name = Console.ReadLine() ?? "";
            //make sure that the name input is not null or ""
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You haven't write anything, try again");
                SignUp();
            }
            Console.WriteLine("Salary of the employee");
            uint salary;
            if (uint.TryParse(Console.ReadLine(), out salary))
            {
                //successfully convert string to int
                //store it to employList
                EmployeeRegister.Empolyee joe = new EmployeeRegister.Empolyee(name, salary);
                employees.Add(joe);

            }
            else
            {
                Console.WriteLine("Write in the right salary");
            }

            ProgramOptions();

        }// end of Sighup

        public static void ShowUp()
        {
            if (employees.Count > 0)
            {
                Console.WriteLine("************************************");
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine("************************************");
            }

            ProgramOptions();
        } // end of ShowUp
    }
}
