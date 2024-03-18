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
            Console.WriteLine("******************Biograf*******************");
            uint number = UserInputHelper.AskForUInt($"You have reached the main menu. To navigate, please enter numbers to test various functions." +
                   $"\n" + "1: Check Price(Youth, Pensioner or Standard)" +
                     $"\n" + "2: Calculate the price for an entire party" +
                     $"\n" + "3: Repeat ten times" +
                     $"'\n" + "4: Print the third word" +
                       $"\n" + "0: Close app");
            //saft convert string to int          
            switch (number)
            {
                case 1:
                    //CheckAge();
                    uint price = CheckAgeAndPrice(out string message);
                    Console.WriteLine(message);
                    break;
                case 2:
                    CalculatePrice();
                    break;
                case 3:
                    Repeat();
                    break;
                case 4:
                    ThirdWord();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }//Meny()
        public static uint CheckAgeAndPrice(out string message)
        {
            uint age = UserInputHelper.AskForUInt("Enter Age");
            if (age < 5 || age > 100)
            {
                message = "Free Enter";
                return 0;
            }
            else if (age >= 5 && age < 20)
            {
                message = "Youth Price: 80kr";
                return 80;
            }
            else if (age >= 20 && age < 80)
            {
                message = "Standard Prics: 120kr";
                return 120;
            }
            else
            {
                message = "Pensioner Price: 90kr";
                return 90;
            }
        }
        //Same logic as CheckPrice but print out price in text
        //public static void CheckAge()
        //{
        //    uint age = UserInputHelper.AskForUInt("Enter Age");
        //    if (age < 5 || age > 100)
        //    {
        //        Console.WriteLine("Free enter!");
        //    }
        //    else if (age < 20)
        //    {
        //        Console.WriteLine("Youth Price: 80kr");
        //    }
        //    else if (age > 64)
        //    {
        //        Console.WriteLine("Pensioner Price: 90kr");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Standard Prics: 120kr");
        //    }
        //}//CheckAge();

        //Check Price for individual
        //could handle exceptions here or in UserinputHelper
        //public static uint CheckPrice()
        //{
        //    uint age = UserInputHelper.AskForUInt("");

        //    if (age < 5 || age > 100)
        //    {
        //        return 0;
        //    }
        //    else if (age >= 5 && age < 20)
        //    {
        //        return 80;
        //    }
        //    else if (age >= 20 && age < 80)
        //    {
        //        return 120;
        //    }
        //    else
        //    {
        //        return 90;
        //    }
        //}
        //Calculate Group price for user
        //Get user uint(positive) input about how many people are there in his/her group
        //Then, ask ages one by one, Check pris for individual and save price in totalPrice.
        public static void CalculatePrice()
        {
            uint numOfpeople = UserInputHelper.AskForUInt("How many people are with you today?");
            uint totalPrice = 0;
            for (int i = 0; i < numOfpeople; i++)
            {
                Console.Write($"How old is the {i + 1} person?");
                totalPrice += CheckAgeAndPrice(out string message);
            }
            Console.WriteLine($"The total price for you group is {totalPrice}kr.");
        }

        //Get string input from user and repeat it ten times
        public static void Repeat()
        {
            string text = UserInputHelper.AskForString("Feel free to write something");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.{text} ");
            }
            Console.WriteLine("");

        }
        //Get a sentence from user and print out the third word
        //Using StringSplitOptions.RemoveEmptyEntries to prevent multipel spaces between words
        public static void ThirdWord()
        {
            string text = UserInputHelper.AskForString("Enter a sentence of at least 3 words");
            var textS = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (textS.Length >= 3)
            {
                Console.WriteLine(textS[2]);
            }
            else
            {
                Console.WriteLine("Sentence should contains at least 3 words");
            }


        }

    }
}
