using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
     public class Department
    {
        public int Id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{name}\t";
            Console.WriteLine("");
            
        }
    }
}
