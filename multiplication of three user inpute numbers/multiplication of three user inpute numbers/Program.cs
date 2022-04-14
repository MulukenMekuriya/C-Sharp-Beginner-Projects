using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_three_user_inpute_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
            Test Data:
            Input the first number to multiply: 2
            Input the second number to multiply: 3
            Input the third number to multiply: 6
            Expected Output:
            2 x 3 x 6 = 36
             */
            int inpute1, inpute2, inpute3;
            Console.WriteLine("Input the First Number: ");
            inpute1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number: ");
            inpute2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third Number: ");
            inpute3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Expected Output:");
            Console.WriteLine(inpute1* inpute2* inpute3);
        }
    }
}
