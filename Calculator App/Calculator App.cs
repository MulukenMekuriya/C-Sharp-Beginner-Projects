using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operator sign");
            string sign = Console.ReadLine();
            Console.Write("Enter second number");
            double num2 = Convert.ToInt32(Console.ReadLine());
            string plus = "+";
            string minus = "-";
            string div = "/";
            string mult = "*";

            if (sign == plus)
            {
                Console.WriteLine(num1 + num2);
            }

            else if (sign == minus)
            {
                Console.WriteLine(num1 - num2);
            }

            else if (sign == div)
            {
                Console.WriteLine(num1 / num2);
            }

          else if (sign == mult)
                    {
                Console.WriteLine(num1 * num2);
            }

            Console.ReadLine();
        }
    }
}
