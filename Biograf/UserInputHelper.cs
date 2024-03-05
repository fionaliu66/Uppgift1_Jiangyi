using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf
{
    public static class UserInputHelper
    {
        public static string AskForString(string message)
        {
            bool success = false;
            string answer;

            do
            {
                Console.WriteLine($"{message}");
                answer = Console.ReadLine() ??"";

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine($"You must enter a valid {message}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static uint AskForUInt(string prompt)
        {

            do
            {
                string input = AskForString(prompt);
                if (uint.TryParse(input, out uint result))
                {
                    return result;
                }
            } while (true);
        }
    }
}
