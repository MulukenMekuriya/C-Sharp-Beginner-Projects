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
            SayHi("Muluken");
            SayHi("John");
            SayHi("Daniel");
            Console.ReadLine();
        }
        static void SayHi(string name)
        {
           Console.WriteLine($"Hello {name}");
        }
    }
}
