using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf
{
    public static class UserInputHelper
    {
        /*If the amount of input data is too large and exceeds the memory limit available on the system,
         * attempting to load the entire input data into memory may result in an OutOfMemoryException exception.
         * 
         * An ArgumentOutOfRangeException exception may be thrown if 
         * contains an invalid value, such as a negative number or a value outside the valid range.
         * Since I am using uint here, a negative number won't trigger this error but out of range may do
         */
        public static string AskForString(string message)
        {
            bool success = false;
            string answer = "";
            try
            {
                do
                {
                    Console.WriteLine($"{message}");
                    answer = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(answer))
                    {
                        Console.WriteLine($"You must enter a valid text");
                    }
                    else
                    {
                        success = true;
                    }

                } while (!success);
            }
            catch (OutOfMemoryException oEx)
            {
                Console.WriteLine("An out of memory error occurred: " + oEx.Message);
            }
            catch (ArgumentOutOfRangeException aogEx)
            {
                Console.WriteLine("An argument out of range error occurred: "+aogEx.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


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
                else
                {
                    Console.WriteLine($"You must enter a valid integer");
                }
            } while (true);
        }
    }
}
