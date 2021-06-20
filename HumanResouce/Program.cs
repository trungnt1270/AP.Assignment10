using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            HummanResourceManagement management = new HummanResourceManagement();
            do
            {
                getMenu();
                do
                {
                    Console.WriteLine("Enter your choice ");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice)
                {
                    case 1:
                        management.DisplayAll();
                        break;
                    case 2:
                        management.DisplayDepartMents();
                        break;
                    case 3:
                        management.AddEmployee();
                        break;
                    case 4:
                        int findId;
                        do
                        {
                            Console.WriteLine("Enter your ID ");
                        } while (!int.TryParse(Console.ReadLine(), out findId));

                        Console.WriteLine("---That resulf of Find By ID------");

                        if (!management.findEmployeeById(findId))
                        {
                            Console.WriteLine("No found ID ");
                        }
                        break;
                    case 5:
                        management.displaySalaryAll();
                        break;
                    case 6:
                        management.staffs.Sort(new SalaryCompare());
                        Console.WriteLine("--------After Sorting--------");

                        management.displaySalaryAll();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }





            } while (true);
            Console.ReadKey();

        }
        static void getMenu()
        {
            Console.WriteLine("------Menu--------");
            Console.WriteLine("1. Hien thi danh sach nhan vien ");
            Console.WriteLine("2. Hien thi cac bo phan trong cong ty");
            Console.WriteLine("3. Them nhan vien moi vao cong ty ");
            Console.WriteLine("4. Tim kiem thong tin nhan vien theo ma ID ");
            Console.WriteLine("5. Hien thi bang luong cua toan cong ty ");
            Console.WriteLine("6. Hien thi bang luong cua nhan vien theo thu tu tang dan ");
            Console.WriteLine("7. Exit");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
