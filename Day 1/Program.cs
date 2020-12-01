using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();

            e.name = "";
            Console.WriteLine(e.name);
            Employee e1 = new Employee();
            e1.name = "pravin";
            Console.WriteLine(e1.name);



            e.BASIC = 190000;
            Console.WriteLine("basic salary = " + e.BASIC);

            e.BASIC = 19000000;

            e.deptNo = 1;
            Console.WriteLine("department no is " + e.deptNo);

            e.deptNo = -2;


            //Employee o1 = new Employee("Amol", 123465, 10);
            //Employee o2 = new Employee("Amol", 123465);
            //Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            //Employee o = new Employee();
            //Console.WriteLine(o.EmpNo);
            //Console.ReadLine();

           // Employee o4 = new Employee();
            Employee o5 = new Employee();
            Employee o6 = new Employee();



            Console.WriteLine("netsalary is " + e.GetNetSalary());

            Console.ReadLine();
        }
    }
    public class Employee
    {
       
       
        short DeptNo;
        decimal deduction;
        decimal NetSalary;

       

        private string Name;

        public string name
        {
            get
            {
                return this.Name;
            }
            set

            {
                if (Name != String.Empty || Name != null)
                {
                    Name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be null or empty string", "Name");
                    Console.ReadLine();
                }
            }
       
        }


        // private static int =0;
        private static int EmpNo = 0;
        public int empNo
        {
            get { return EmpNo; }
            
        }

        private decimal Basic;

        public decimal BASIC
        {
           set
            {
                if(value>11000 && value<999999)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("Given Value is Not in Range !!");
                }
            }

            get
            {
                return Basic;
                
            }
        }

        private short DeptNO;

        public short deptNo
        {
            set
            {
               if(value > 0)
                {
                    DeptNo = value; 
                }
            }
            get
            {
                return DeptNo;
            }
        }

        public decimal GetNetSalary()
        {

            decimal basic = 110000;
            decimal hra = 70000;
            decimal da = 40000;

            decimal netSalary = basic + hra + da;

            return netSalary;
        }
       // public int MyProperty { get; set; }
        public Employee()
        {
            Name = "Pravin";
            NetSalary = 200000;
            DeptNo = 1;
            EmpNo++;
            Console.WriteLine(Name + " " + NetSalary + " " + DeptNo+" "+EmpNo);
            Console.ReadLine();

        }
        public Employee(string Name, decimal NetSalary,short DeptNo)
        {
            this.Name = Name;
            this.NetSalary = NetSalary;
            this.DeptNo = DeptNo;

            

            Console.WriteLine(Name+" "+NetSalary+" "+DeptNo);
            Console.ReadLine();
        }
        public Employee(string Name, decimal NetSalary)
        {
            this.Name = Name;
            this.NetSalary = NetSalary;

        
            Console.WriteLine(Name+" "+NetSalary);
            Console.ReadLine();
        }
        public Employee(string Name)
        {
            this.Name = Name;
            Console.WriteLine(Name);
            Console.ReadLine();
        }
    }
}
