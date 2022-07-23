using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Program
    {
        static void Main()
        {
            STudent sTudent = new STudent();
            sTudent.Id = 1;
            sTudent.Name = "sTudent";
            sTudent.Take_Exam(sTudent);

            Console.WriteLine("The name is "+sTudent.Name+ "and its ID is" +sTudent.Id);
            Console.ReadLine();
        }
        


    }
}
