using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
    class SalaryCompare : IComparer<Staff>
    {
        public int Compare(Staff x, Staff y)
        {
            return Convert.ToInt32(x.Salary) - Convert.ToInt32(y.Salary);

        }
    }
}
