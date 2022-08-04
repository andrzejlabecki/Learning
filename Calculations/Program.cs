
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

            Test1();
            Test2();
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
    }
}