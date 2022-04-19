using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_operation_with_user_inpute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
Test Data:
             */
            int inpute1, inpute2;

            Console.WriteLine("Enter the first number: ");
            inpute1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            inpute2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Expected output:");
            Console.WriteLine($"inpute1+inpute2 = {inpute1 + inpute2}");
            Console.WriteLine($"inpute1-inpute2 = {inpute1 - inpute2}");
            Console.WriteLine($"inpute1*inpute2 = {inpute1 * inpute2}");
            Console.WriteLine($"inpute1/inpute2 = {inpute1 / inpute2}");
            Console.WriteLine($"inpute1%inpute2 = {inpute1 % inpute2}");

        }
    }
}
