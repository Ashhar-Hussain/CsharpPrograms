using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // initialization

            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }
            Console.ReadLine();
        }
    }
}
