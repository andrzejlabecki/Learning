
using System;
using System.Reflection.Metadata;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operators
            // '+' add
            // '-' subtract
            // '*' multiply
            // '/' divide
            // 'Math.Pow(x, y)' y power of x

            //Test1();
            //Test2();

            // pi calculation by using the Leibniz formula
            // pi/4 = 1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + ...

            // pi with first 50 digits
            string strPi = "3.14159265358979323846264338327950288419716939937510";
            Console.WriteLine(strPi);

            //int numTerms = 100;
            long numTerms = 1000000000;

            DateTime start = DateTime.Now;
            //double pi = CalculatePiInt(numTerms);
            //double pi = CalculatePiLong(numTerms);
            decimal pi = CalculatePiDecimal(numTerms);
            DateTime end = DateTime.Now;

            double seconds = (end - start).TotalSeconds;

            strPi = pi.ToString();

            Console.WriteLine(strPi);

            int digits = strPi.Length - 2;
            Console.WriteLine(digits.ToString() + " - digits");
            Console.WriteLine(seconds.ToString() + " - seconds");

            Console.WriteLine("Press any key to exit... ");

            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("Test #1");
            Console.WriteLine("Calculate - (Pow((3.75/5), 2)  + 4 + 3/8) - 0.625");

            double a = (double)3.75 / (double)5;
            //double b = Math.Pow(a, 2);
            double b = a * a;
            double c = b + 4 + (double)3 / (double)8;
            double d = c - (double)0.625;

            double answer = 4 + (double)5 / (double)16;
            double test = 5 / 16;

            Console.WriteLine("Result = " + d);
            Console.WriteLine("Answer = " + answer);
            Console.WriteLine("Test = " + test);
            Console.WriteLine("Press any button to exit...");
            Console.ReadKey();
        }

        static void Test2()
        {
            Console.WriteLine("Test #2");
            Console.WriteLine("Calculate - (Pow((3.75/5), 2)  + 4 + 3/8) - 7/8");

            double a = (double)3.75 / (double)5;
            //double b = Math.Pow(a, 2);
            double b = a * a;
            double c = b + 4 + (double)3 / (double)8;
            double d = c - (double)7 / (double)8;

            double answer = 4 + (double)1 / (double)16;
            double test = 1 / 16;

            Console.WriteLine("Result = " + d);
            Console.WriteLine("Answer = " + answer);
            Console.WriteLine("Test = " + test);
            Console.WriteLine("Press any button to exit...");
            Console.ReadKey();
        }

        public static double CalculatePiInt(int numTerms)
        {
            double pi = 0.0;
            bool positive = true;
            for (int i = 1; i <= numTerms; i += 2)
            {
                if (positive)
                {
                    pi += 1.0 / i;
                }
                else
                {
                    pi -= 1.0 / i;
                }
                positive = !positive;
            }
            return 4.0 * pi;
        }

        public static double CalculatePiLong(long numTerms)
        {
            double pi = 0.0;
            bool positive = true;
            for (long i = 1; i <= numTerms; i += 2)
            {
                if (positive)
                {
                    pi += 1.0 / i;
                }
                else
                {
                    pi -= 1.0 / i;
                }
                positive = !positive;
            }
            return 4.0 * pi;
        }

        public static decimal CalculatePiDecimal(long numTerms)
        {
            decimal pi = (decimal)0.0;
            bool positive = true;
            for (long i = 1; i <= numTerms; i += 2)
            {
                if (positive)
                {
                    pi += (decimal)1.0/i;
                }
                else
                {
                    pi -= (decimal)1.0/i;
                }
                positive = !positive;
            }
            return (decimal)4.0*pi;
        }
    }
}