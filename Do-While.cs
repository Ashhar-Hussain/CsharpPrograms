using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("please enter a value");
            i =Convert.ToInt32(Console.ReadLine());
            do
            {
              
                if (i>1)
                {
                    Console.WriteLine(i);
                }
            } while (i==1);
            Console.ReadLine();

        }
    }
}
