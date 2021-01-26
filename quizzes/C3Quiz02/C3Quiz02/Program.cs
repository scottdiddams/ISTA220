using System;

namespace C3Quiz02
{
    class Program
    {
        static void Main(string[] lenny)
        {
            Console.WriteLine("C Sharp Quiz 2");
            Console.WriteLine("Calculating phi using a recursive method by the Fibonacci series");
            Console.WriteLine($"Calling, CalcPhi");
            CalcPhi(1, 1, 1, 40);
            Console.ReadLine();
        }

        public static void CalcPhi(double a, double b, double counter, double limit)
        {
            RecursiveFun(a, b, counter, limit);
           
        }

        public static void RecursiveFun(double a, double b, double counter, double limit)

        {
            if (counter <= limit)
            {
                double C = (b / a);
                Console.WriteLine("{0} & {1} = {2}, ", a, b, C);
                RecursiveFun(b, a + b, counter + 1, limit);
            }

        }
    }
}
