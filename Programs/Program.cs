using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int name;
            name =Convert.ToInt32(Console.ReadLine());
            if (name<=1)
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("You are not");
            }
            Console.ReadLine();
        }
    }
}
