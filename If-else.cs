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
            int Age;
            Console.WriteLine("please enter your age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is "+Age);
            Console.ReadLine();
        }
    }
}
