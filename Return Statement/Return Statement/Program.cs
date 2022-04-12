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
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);

        }
        static int Cube(int num)
        {
            int result = num*num*num;
            return result;
        }
    }
}
