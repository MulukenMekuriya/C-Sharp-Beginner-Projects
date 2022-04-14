using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to swap two numbers.
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6
            Expected Output:
            After Swapping :
            First Number : 61
            Second Number : 5
                        */
            Console.WriteLine("Input the First Number: ");
            string inpute1 = Console.ReadLine();
            Console.WriteLine("Input the Second Number: ");
            string inpute2 = Console.ReadLine();
            Console.WriteLine("Expected Output:");
            Console.WriteLine("After Swapping :");
            Console.WriteLine($"First Number :{inpute2}");
            Console.WriteLine($"Second Number :{inpute1}");
        }
    }
}
