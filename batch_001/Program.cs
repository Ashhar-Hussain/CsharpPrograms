using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Name;
            Console.WriteLine("Please enter your name");
            Name = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("welcome to program "+Name);
            Console.ReadLine();
        }
    }
}
