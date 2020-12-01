using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Employee
    {
        static int count;
        string name;
        int empNo;
        decimal basic;
        short deptNo;
        #region Property

        public string Name
        {
            set
            {
                if (value.Length <= 0 || value.Equals(null))
                {
                    Console.WriteLine("Name can't be Blank");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int EmpNo
        {
            get { return empNo;  }
        }

        public decimal Basic
        {
            set
            {
                if(value >= 5000.5m && value <= 50000.5m)
                {
                    this.basic = value;
                }
                else
                {
                    Console.WriteLine("Basis value should be in Range 5000.5 to 50000.5");
                }
            }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    this.deptNo = value;
                }
                else
                {
                    Console.WriteLine("Department number should be greater than Zero and less than 128");
                }
            }
        }
        #endregion

        Employee()
        {

        }
        Employee(string name)
        {
            this.empNo = ++count;
            this.Name = name;
        }
        Employee(string name, decimal basic)
        {
            this.empNo = ++count;
            this.Name = name;
            this.Basic = basic;
        }

        Employee(string name,decimal basic,short deptNo)
        {
            this.empNo = ++count;
            this.Name = name;
            this.Basic = basic;
            this.deptNo = deptNo;
        }

        public decimal GetNetSalary()
        {
            return this.basic * 0.05m + 4500;
        }

        public string toString()
        {
            return "Name : " + this.name  + " EMP : "+ this.empNo + "  Employee salary  : " + this.GetNetSalary();
        }
        public static void Main()
        {
            Employee o1 = new Employee("Amol", 12346555, 1015);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();
            Console.WriteLine(o1.toString());
            Console.WriteLine(o2.toString());
            Console.WriteLine(o3.toString());
            Console.WriteLine(o4.toString());
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);


        }

    }
}

