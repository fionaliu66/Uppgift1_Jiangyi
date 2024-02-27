namespace Uppgift1_Jiangyi
{
    internal class Program
    {
        /*
         * Could create class or struct here to store all employs, 
         * but since the information of employs are few and no calculation or function needed for the employs,
         * I choose to use a simply dictionary here to store them. 
         */
        private static Dictionary<string, int> employList = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            //ask for employ input
            
            ProgramOptions();

        }
        //i donnot like use for or while loop here
        //just call ProgramOption whenever user is done with preious action
        public static void ProgramOptions()
        {
            Console.WriteLine("What whould you like to do today");
            Console.WriteLine("1: Resgiter new employ");
            Console.WriteLine("2: Print out all members");
            Console.WriteLine("3: Close app");
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
            Console.WriteLine("Name of the employ");
            string name = Console.ReadLine() ?? "";
            //make sure that the name input is not null or ""
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You haven't write anything, try again");
                SignUp();
            }
            Console.WriteLine("Salary of the employ");
            int salary;
            if (int.TryParse(Console.ReadLine(), out salary))
                {
                    //successfully convert string to int
                    //store it to employList
                    employList.Add(name, salary);

                }
                else
                {
                    Console.WriteLine("Write in the right salary");
                }
            
            ProgramOptions();

        }// end of Sighup

       public static void ShowUp()
        {
            if (employList.Count > 0)
            {
                Console.WriteLine("************************************");
                foreach (var employ in employList)
                {
                    Console.WriteLine($"Name: {employ.Key}, Salary: {employ.Value}");
                }
                Console.WriteLine("************************************");
            }
            
            ProgramOptions();
        } // end of ShowUp
    }
}
