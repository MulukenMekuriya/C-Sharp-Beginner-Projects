using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cube(2);
            Console.WriteLine(Cube(2));

        }
        static int Cube(int num)
        {
            int result = num*num*num;
            return result;
        }
    }
}
