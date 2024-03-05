namespace Biograf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //show meny to user at least once 
                Meny();

            } while (true);
        }//Main


        public static void Meny()
        {
            uint number = AskForInt($"You have reached the main menu. To navigate, please enter numbers to test various functions." +
                   $"\n" + "1: Check Price(Youth,Pensioner or Standard)" +
                     $"\n" + "2: Calculate the price for an entire party" +
                     $"\n" + "3: Repeat ten times"+
                       $"\n" + "0: Close app");
            //saft convert string to int          
            switch (number)
            {
                case 1:
                    CheckAge();
                    break;
                case 2:
                    CalculatePrice();
                    break;
                case 3:
                    Repeat();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }//Meny()


        public static void CheckAge()
        {
            uint age = AskForInt("Enter Age");
            if (age < 20)
            {
                Console.WriteLine("Youth Price: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensioner Price: 90kr");
            }
            else
            {
                Console.WriteLine("Standard Prics: 120kr");
            }
        }//CheckAge();
        public static uint CheckPris()
        {
            uint age = AskForInt("Enter Age");
            if (age < 20)
            {
                return 80;
            }
            else if (age > 64)
            {
                return 90;
            }
            else
            {
                return 120;
            }
        }
        public static uint AskForInt(string message)
        {
            bool success = false;
            string answer;
            uint result = 0;
            do
            {
                Console.WriteLine($"{message}");
                answer = Console.ReadLine() ?? "";
                if (!string.IsNullOrEmpty(answer))
                {
                    if (uint.TryParse(answer, out result))
                    {
                        success = true;
                    }
                }
                else
                {
                    Console.WriteLine("You must enter a valid number");
                    success = false;
                }
            } while (!success);

            return result;
        }
        public static void CalculatePrice()
        {
            uint numOfpeople = AskForInt("How many people are with you today?");
            uint totalPrice = 0;
            for (int i = 0; i < numOfpeople; i++)
            {
                Console.Write($"How old is the {i + 1} person?");
                totalPrice += CheckPris();
            }
            Console.WriteLine($"The total price for you group is {totalPrice}kr.");
        }

        public static void Repeat()
        {
            string text = Console.ReadLine() ?? "";
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {

            }
        }



    }
}
