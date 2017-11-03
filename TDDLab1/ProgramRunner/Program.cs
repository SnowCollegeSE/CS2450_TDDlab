using Lib1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter me a value, and I'll give you the primes lower than it:");
            var input = Console.ReadLine();
            var num = int.Parse(input);
            //todo - handle non-numeric values
            Console.WriteLine(Prime.ListPrimesLTEQ(num));
            //wait for user to see
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }
    }
}
