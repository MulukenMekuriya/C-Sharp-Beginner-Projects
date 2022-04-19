using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_user_inpute_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# Sharp program that takes four numbers as input to calculate and print the average
             */
            int inpute1, inpute2, inpute3, inpute4;
            Console.WriteLine("Enter inpute 1");
                inpute1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inpute 2");
            inpute2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inpute 3");
            inpute3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inpute 4");
            inpute4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Expeceted output is : {(inpute1+inpute2+inpute3+inpute4)/4}");


        }
    }
}
