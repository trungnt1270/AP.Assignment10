using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
   public class Manager : Staff, ICalculator
    {
        public Postion postion { get; set; }
        public override double Salary 
        {
            get
            {
                return CacaulateSalary();
            }
        }

        public double CacaulateSalary()
        {
            double salaryResponsibility = 0;
            switch (postion) 
            {
                case Postion.BusinessLeader:
                    salaryResponsibility = 8_000_000;
                    break;
                case Postion.ProhjectLeader:
                    salaryResponsibility = 5_000_000;
                    break;
                case Postion.TechnicalLeader:
                    salaryResponsibility = 6_000_000;
                    break;
            }
            return SalaryRate * 5_000_000 + salaryResponsibility;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Department : " + department.name);
            Console.WriteLine("Date of join : " + DateofJoin);
            Console.WriteLine("Vacation " + Vacation);
            Console.WriteLine("Position : " + postion);
            Console.WriteLine("Salary : " + Salary);
        }
        public override void Add()
        {
            int choie;
           
            base.Add();


            Console.WriteLine("---Choose the Position--- ");
            Console.WriteLine("1. BusinessLeader");
            Console.WriteLine("2. ProhjectLeader ");
            Console.WriteLine("3. TechnicalLeader ");
            do
            {
                Console.WriteLine("Enter your choice ");

            } while (!int.TryParse(Console.ReadLine(), out choie));

            switch (choie)
            {
                case 1:
                    postion = Postion.BusinessLeader;
                    break;
                case 2:
                    postion = Postion.ProhjectLeader;
                    break;
                case 3:
                    postion = Postion.TechnicalLeader;
                    break;
                default:
                    break;
            }

        }
    }
}
