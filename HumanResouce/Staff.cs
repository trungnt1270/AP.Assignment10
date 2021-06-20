using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
    public abstract class Staff
    {
        public int Id { get; set; }
    public  string Name { get; set; }
    public  int Age { get; set; }
       public double SalaryRate { get; set; }
    public  DateTime DateofJoin { get; set; }
        public Department department { get; set;            }
    public int Vacation { get; set; }

        public abstract double Salary { get; }
        public abstract void DisplayInformation();

        public  virtual void Add()
        {
            int choie;
            int id;
            string name;
            int age;
            double SalaryRate;
            DateTime dateofjoin;
            int Vacation;

            do
            {
                Console.WriteLine("Input the id ");
            } while (!int.TryParse(Console.ReadLine(), out id));

            Console.WriteLine("Input the Name :");
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("Input the age ");
            } while (!int.TryParse(Console.ReadLine(), out age));

            do
            {
                Console.WriteLine("Input the SalaryRate ");
            } while (!double.TryParse(Console.ReadLine(), out SalaryRate));

            do
            {
                Console.WriteLine("Input the Date of join ");
            } while (!DateTime.TryParse(Console.ReadLine(), out dateofjoin));


            Console.WriteLine("---Choose the Department--- ");
            Console.WriteLine("1. Marketing");
            Console.WriteLine("2. Sale ");
            Console.WriteLine("3. HR ");
            Console.WriteLine("4. Techlogoly ");
            do
            {
                Console.WriteLine("Enter your choice ");

            } while (!int.TryParse(Console.ReadLine(), out choie));

            switch (choie)
            {
                case 1:
                    department = new Department();
                    department.name = Convert.ToString(EnumDepartMenet.Marketing);
                    break;
                case 2:
                    department = new Department();
                    department.name = Convert.ToString(EnumDepartMenet.Sale);
                    break;
                case 3:
                    department = new Department();
                    department.name = Convert.ToString(EnumDepartMenet.HR);
                    break;
                case 4:
                    department = new Department();
                    department.name = Convert.ToString(EnumDepartMenet.Techlogoly);
                    break;

                default:
                    break;
            }

            do
            {
                Console.WriteLine("Input the vacation ");
            } while (!int.TryParse(Console.ReadLine(), out Vacation));

            Id = id;
            Name = name;
            this.SalaryRate = SalaryRate;
            Age = age;
            DateofJoin = dateofjoin;
            this.Vacation = Vacation;
            

            

        }
         
    }
}
