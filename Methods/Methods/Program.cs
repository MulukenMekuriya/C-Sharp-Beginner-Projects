using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Muluken", 10);
            SayHi("John", 30);
            SayHi("Daniel", 50);
            Console.ReadLine();
        }
        static void SayHi(string name, int age)
        {
           Console.WriteLine($"Hello {name}, you are {age} years old.");
        }
    }
}
