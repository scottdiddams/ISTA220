using System;

namespace C3Quiz03
{
    class Program
    {
        static void Main(string[] lenny)
        {

            bool mainMenu = true;
            while (mainMenu)
            {
                mainMenu = StartMenu();
            }



        }

        private static bool StartMenu()
        {
            Console.WriteLine("Type a non-negative integer to get its reciprocal");
            Console.WriteLine("To exit, type 'exit'");
            string entry = Console.ReadLine();
            if (entry == "exit")
            {
                Console.WriteLine("Bye");
                Console.ReadLine();
                return false;
            }
            else
            {
                reciprocal(entry);
                Console.ReadLine();
                return true;
            }
        }

        private static void reciprocal(string entry)
        {
            try
            {
                if (Int32.Parse(entry) < 0)
                {
                    Console.WriteLine("Follow instructions - no negatives - try again");
                }
                else if (Int32.Parse(entry) == 0)
                {
                    Console.WriteLine("Let's avoid dividing by zero - try again");
                }
                else
                {
                    double intEntry = Int32.Parse(entry);
                    double recip = (1 / intEntry);
                    Console.WriteLine($"The reciprocal of {entry} is {recip}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"WRONG! {entry} is not an integer");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Well...I can tell you the limit does not exist, but let's avoid dividing by zero");
            }
        }
    }
}
