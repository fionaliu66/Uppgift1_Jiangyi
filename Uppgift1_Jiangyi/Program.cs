namespace Uppgift1_Jiangyi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask for employ input
            Dictionary<string, int> employList = new Dictionary<string, int>();
            ProgramOptions();

            void ProgramOptions()
            {
                Console.WriteLine("What whould you like to do today");
                Console.WriteLine("1: Resgiter new employ");
                Console.WriteLine("2: Print out all members");
                Console.WriteLine("3: Close app");
                string choice = Console.ReadLine() ?? "";

                int number;
                //saft convert string to int
                if(int.TryParse(choice, out number))
                {
                    if(number >= 1 && number <= 3)
                    {
                        switch(number)
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

            void SignUp()
            {
                Console.WriteLine("Name of the employ");
                string name = Console.ReadLine();
                if(name != null)
                {
                    Console.WriteLine("Salary of the employ");
                    int salary;
                    if(int.TryParse(Console.ReadLine(), out salary))
                    {
                        //successfully convert string to int
                        //store it to employList
                        employList.Add(name, salary);

                    }
                    else
                    {
                        Console.WriteLine("Write in the right salary");
                    }
                }
                else
                {
                    Console.WriteLine("Name cannot be Null");
                }
                ProgramOptions();

            }// end of Sighup

            void ShowUp()
            {
                if(employList.Count > 0)
                {
                    foreach(var employ in employList)
                    {
                        Console.WriteLine($"Name: {employ.Key}, Salary: {employ.Value}");
                    }
                }
                ProgramOptions();
            } // end of ShowUp

        }
    }
}
