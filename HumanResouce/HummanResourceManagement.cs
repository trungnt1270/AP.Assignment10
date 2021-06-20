using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
    class HummanResourceManagement
    {
       public List<Staff> staffs;
        Staff staff = null;
        List<Department> departments = new List<Department>()
        {
            new Department { Id = 1, name = "Marketing"},
            new Department { Id = 2, name = "Sale"},
            new Department { Id = 3, name = "HR"},
            new Department { Id = 4, name = "Techlogy"},
        };

        public HummanResourceManagement()
        {
            staffs = new List<Staff>();
        }
        public void DisplayAll()
        {
            foreach (var staff in staffs)
            {
                staff.DisplayInformation();
            }
        }
        public void DisplayDepartMents()
        {
            foreach (var department in departments)
            {
                Console.WriteLine(department.ToString());
            }
        }

        public void AddEmployee()
        {

            int choice;
            Console.WriteLine("---List of type Employee------");
            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Manager");
            do
            {
                Console.WriteLine("Enter type of Employee you wanwt to add");

            } while (!int.TryParse(Console.ReadLine(), out choice));

            switch (choice)
            {
                case 1:
                    staff = new Employee();
                    staff.Add();
                    break;
                case 2:
                    staff = new Manager();
                    staff.Add();
                    break;

                default:
                    break;
            }

            staffs.Add(staff);
        }

        public bool findEmployeeById(int id)
        {
            bool check = false;
            foreach (var staff in staffs)
            {
                if (staff.Id == id)
                {
                    check = true;
                    staff.DisplayInformation();
                    break;
                }

            }
            return check;
        }

        public void displaySalaryAll()
        {
            Console.WriteLine("--Salary of all Employee----");
            Console.WriteLine("ID\tName\t\tSalary");
            foreach (var staff in staffs)
            {
                Console.WriteLine($"{staff.Id}\t{staff.Name}\t\t{staff.Salary}");
            }
        }


    }
}
