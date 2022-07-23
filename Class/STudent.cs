using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class STudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        
        public void Take_Exam(STudent abc)
        {
            Console.WriteLine("this student can take exam #"+abc.Name);
        }
    }
}
