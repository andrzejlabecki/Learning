
using System;
using System.Reflection.Metadata;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";

            char char1 = text[1];

            Console.WriteLine("Text - '" + text + "'");

            string reversedText = ReverseString(text);

            Console.WriteLine("Reversed Text - '" + reversedText + "'");

            char[] textArray = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            string str = new string(textArray);
            Console.WriteLine("Array Text - '" + str + "'");

            char[] reversedTextArray = ReverseTextArrayEx(textArray);
            str = new string(reversedTextArray);
            Console.WriteLine("Reversed Array Text - '" + str + "'");

            Console.WriteLine("Press any button to exit...");
            Console.ReadKey();
        }

        static string ReverseString(string inputString)
        {
            string reversedString = string.Empty;
            int length = inputString.Length;

            for (int i = length-1; i >= 0; i--) 
            {
                reversedString += inputString[i];   
            }

            return reversedString;
        }

        static string CopyString(string inputString)
        {
            string copyString = string.Empty;

            return copyString;
        }

        static char[] ReverseTextArray(char [] inputArray)
        {
            int length = inputArray.Length;
            char[] reversedArray = new char[length];

            for (int i = length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[j] += inputArray[i];
            }

            return reversedArray;
        }

        static char[] CopyTextArray(char[] inputArray)
        {
            int length = inputArray.Length;
            char[] copyArray = new char[length];

            return copyArray;
        }

        static char[] ReverseTextArrayEx(char[] inputArray)
        {
            int length = inputArray.Length;
            char ch = '\0';
            int count = length / 2;

            for (int i = 0; i < count; i++)
            {
                ch = inputArray[i];
                inputArray[i] = inputArray[length - i - 1];
                inputArray[length - i - 1] = ch;
            }

            return inputArray;
        }
    }
}