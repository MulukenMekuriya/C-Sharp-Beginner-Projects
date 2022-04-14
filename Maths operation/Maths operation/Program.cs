using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
             */
            int inpute1, inpute2;
            Console.WriteLine("Input the First Number: ");
            inpute1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number: ");
            inpute2 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Expected Output:");
            Console.WriteLine(inpute1 + inpute2);
            Console.WriteLine(inpute1 - inpute2);
            Console.WriteLine(inpute1* inpute2);
            Console.WriteLine(inpute1/ inpute2);
            Console.WriteLine(inpute1 % inpute2);
        }
    }
}
