using System;

namespace ProgEx01
{
    class Program
    {
        static void Main(string[] lenny)
        {
            bool displayMenu = true;
            while (displayMenu)
                
            {
                try
                {
                    displayMenu = checked(MainMenu());
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.Write("Improper Format - think on your sins");
                    Console.ReadLine();
                }
                catch (OverflowException)
                {
                    Console.Write("Overflow - the answer is too large");
                    Console.ReadLine();
                }
                finally
                {
                    Console.WriteLine("Closing up shop");
                }
            }

           

        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose and Option");
            Console.WriteLine("1) Radius of a circle");
            Console.WriteLine("2) Volume of a hemisphere");
            Console.WriteLine("3) Area of a triangle");
            Console.WriteLine("4) Quadratic Solver");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                CircRad();
                return true;
            }
            else if (result == "2")
            {
                HemiVol();
                return true;
            }
            else if (result == "3")
            {
                TriArea();
                return true;
            }
            else if (result == "4")
            {
                Quadratic();
                return true;
            }
            else if (result == "5")
            {
                Console.WriteLine("GoodBye");
                return false;
            }
            else
            {
                Console.Write("That's Not an Option");
                return true;
            }
        }
        private static void CircRad()
        {
            Console.WriteLine("Ready to play with circles!?");
            Console.Write("Enter an integer for the radius:");
            int intradius = int.Parse(Console.ReadLine());
            if (intradius < 1)
            {
                Console.WriteLine("Lets not do negative numbers today - go back and try again");
            }
            else
            {
                double circumference = 2 * (Math.PI) * intradius;
                double area = (Math.PI) * intradius * intradius;
                Console.WriteLine($"The circumference is {circumference}! and the Area is {area}!");
                Console.ReadLine();
            }
            
        }

        private static void HemiVol()
        {
            Console.WriteLine("Hemispheres!?");
            Console.Write("Write me up a radius:");
            //string strhemrad = Console.ReadLine();
            int inthemrad = int.Parse(Console.ReadLine());
            if (inthemrad < 1)
            {
                Console.WriteLine("Lets not do negative numbers today - go back and try again");
            }
            else
            {
                double volHem = ((4 / 3) * (Math.PI) * (inthemrad * inthemrad * inthemrad)) / 2;
                Console.WriteLine($"Your hemisphere volume is {volHem}!");
                Console.ReadLine();
                Console.WriteLine("Isn't math neat!?");
            }
            
        }

        private static void TriArea()
        {
            Console.WriteLine("How about some triangles?! - enter two values for sides of a triangle:");
            Console.Write("Side a:");
            //string strSideA = Console.ReadLine();
            int intSideA = int.Parse(Console.ReadLine());
            Console.Write("Side b:");
            //string strSideB = Console.ReadLine();
            int intSideB = int.Parse(Console.ReadLine());
            if (intSideA < 1 | intSideB < 1)
            {
                Console.WriteLine("Lets not do negative numbers today - go back and try again");
            }
            else
            {
                double dblSideC = Math.Sqrt((intSideA * intSideA) + (intSideB * intSideB));
                Console.WriteLine($"and your third side is therefore: {dblSideC}");
                Console.WriteLine("Isn't pythagoras neat!");
                Console.ReadLine();
                double dblP = ((intSideA + intSideB + dblSideC) / 2);
                int intP = Convert.ToInt32(dblP);
                double triArea = Math.Sqrt((intP * (intP - intSideA) * (intP - intSideB) * (intP - dblSideC)));
                Console.WriteLine($"The area of this triangle is: {triArea}");
                Console.ReadLine();
            }
            
        }
        private static void Quadratic()
        {
            Console.WriteLine("How about some quadratics!?: give me your a, b, and c values:");
            Console.Write("a:");
            int intA = int.Parse(Console.ReadLine());
            Console.Write("b:");
            int intB = int.Parse(Console.ReadLine());
            Console.Write("c:");
            int intC = int.Parse(Console.ReadLine());
            
            double root1 = (-intB + (Math.Sqrt((intB * intB) - (4 * intA * intC))) / (2 * intA));
            double root2 = (-intB - (Math.Sqrt((intB * intB) - (4 * intA * intC))) / (2 * intA));
            if ((intB*intB)-4*(intA*intC)<0)
            {
                Console.WriteLine("There are no real roots");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your roots are {root1} and {root2}!");
                Console.ReadLine();
            }
            
        }
        
    }
}
