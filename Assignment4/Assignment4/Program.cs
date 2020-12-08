using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main1(string[] args)
        {
            // object[] arr1 = new object[1];
            Employees[] arr = new Employees[3];
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter Employee {i} Id  : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Employee {i} Name : ");
                string name = Console.ReadLine();
                Console.Write($"Enter Employee {i} Sal : ");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                arr[0] = new Employees(id, name, sal);
            }

            
            //Method 2
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].EmpSal > arr[j + 1].EmpSal)
                    {

                        Employees temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpSal == arr[arr.Length - 1].EmpSal)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }


            int eno = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpId == eno)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }





            Console.ReadLine();
        }

    }

    class Employees
    {
        private int empId;

        private string empName;
        private decimal empSal;

        public int EmpId
        {
            get;
            set;
        }
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }

        public Employees(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }

    }
}