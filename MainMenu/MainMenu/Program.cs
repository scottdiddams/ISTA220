using System;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] lenny)
        {
            bool startMenu = true;
            while (startMenu)
            {
                Console.Clear();
                startMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("1: ");
            Console.WriteLine("2: ");
            Console.WriteLine("3: ");
            Console.WriteLine("4: exit");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    methodChoice1();
                    return true;

                case 2:
                    MethodChoice2();
                    return true;

                case 3:
                    MethodChoice3();
                    return true;

                case 4:
                    Console.WriteLine("GoodBye");
                    Console.ReadLine();
                    return false;

                default:
                    Console.WriteLine("Thats not an option");
                    Console.ReadLine();
                    return true;
            }


        }



        private static void methodChoice1()
        {
            Console.WriteLine("Choice 1");
            Console.ReadLine();
        }


        private static void MethodChoice3()
        {
            Console.WriteLine("Choice 3");
            Console.ReadLine();
        }

        private static void MethodChoice2()
        {
            Console.WriteLine("Choice 2");
            Console.ReadLine();
        }
    }
}
