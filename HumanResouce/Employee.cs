using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
    public class Employee : Staff, ICalculator
    {
        public int overTime { get; set; }
        public override double Salary 
        {
            get
            {
                return CacaulateSalary();
            }
        }

        public double CacaulateSalary()
        {
            return SalaryRate * SalaryConst.salaryEmployeeRate + overTime * SalaryConst.OverTimeRate;

        }

        public override void DisplayInformation()
        {
            Console.WriteLine("---Here is infomation---");
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Department : " + department.name);
            Console.WriteLine("Date of join : " + DateofJoin);
            Console.WriteLine("Vacation " + Vacation);
            Console.WriteLine("Over Time: " + overTime);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("---------------------------");
        }
        public override void Add()
        {
            int overTime;
            base.Add();

            do
            {
                Console.WriteLine("Input the Over time ");
            } while (!int.TryParse(Console.ReadLine(), out overTime));
            this.overTime = overTime;

        }
    }
}
