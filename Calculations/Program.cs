
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

            int a = 1;
            long b = 1;
            double c = 1;

            int sizeOfInt = sizeof(int);          // 4 bytes
            int sizeOfLong = sizeof(long);          // 4 bytes
            int sizeOfChar = sizeof(char);        // 2 bytes
            int sizeOfFloat = sizeof(float);    // 4 bytes
            int sizeOfDouble = sizeof(double);    // 8 bytes
            int sizeOfBool = sizeof(bool);    // 1 byte

            Test1();
            Test2();

            // pi calculation by using the Leibniz formula
            // pi/4 = 1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + ...

            // pi with first 50 digits
            //string strPi = "3.14159265358979323846264338327950288419716939937510";
            //Console.WriteLine(strPi);

            //int numTerms = 100;
            //long numTerms = 1000000000;

            //DateTime start = DateTime.Now;
            //double pi = CalculatePiInt(numTerms);
            //double pi = CalculatePiLong(numTerms);
            //decimal pi = CalculatePiDecimal(numTerms);
            //DateTime end = DateTime.Now;

            //double seconds = (end - start).TotalSeconds;

            //strPi = pi.ToString();

            //Console.WriteLine(strPi);

            //int digits = strPi.Length - 2;
            //Console.WriteLine(digits.ToString() + " - digits");
            //Console.WriteLine(seconds.ToString() + " - seconds");

            //Console.WriteLine("Press any key to exit... ");

            //Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("Test #1");
            Console.WriteLine("Calculate - Pow((3.75/5), 2)  + 4 + 3/8 - 7/8");

            double a = (double)3.75 / (double)5;
            double b = Math.Pow(a, 2);
            //double b = a * a;
            double c = (double)3/(double)8;
            double d = b + 4 + c;
            double e = (double)7/(double)8;
            double result1 = d - e;

            double result2 = Math.Pow((double)3.75/(double)5, 2) + (double)4 + (double)3/(double)8 - (double)7/(double)8;

            Console.WriteLine("Result1 = " + result1);
            Console.WriteLine("Result2 = " + result2);
            Console.WriteLine("Press any button to exit...");
            Console.ReadKey();
        }

        static void Test2()
        {
            Console.WriteLine("Test #2");
            Console.WriteLine("Calculate - Pow((3.75/5), 2)  + 4 + 3/8 - 7/8");

            double a = 3.75 / 5;
            //double b = Math.Pow(a, 2);
            double b = a * a;
            double c = 3/8;
            double d = b + 4 + c;
            double result = d - 7/8;

            Console.WriteLine("Result = " + result);
            Console.WriteLine("Press any button to exit...");
            Console.ReadKey();
        }

        static void Test3()
        {
            Console.WriteLine("Test #3");
            Console.WriteLine("Calculate - Pow((8-3.75/5), 4/9)  + 5.7 + 3/8*7 - 7/8/9");
            double result = 0;

            Console.WriteLine("Result = " + result);
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