using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3
{
    public abstract class Employee
    {
        static int count;
        string name;
        int empNo;
        short deptNo;
        public decimal basic;
        #region Property
        public string Name
        {
            set
            {
                if (value != "" && value != null)
                {
                    this.name = value;
                }
            }
            get
            {
                return this.name;
            }
        }
        public int EmpNo
        {
            get
            {
                return this.empNo;
            }
            private set
            {
                this.empNo = value;
            }
        }
        public short DeptNo
        {
            set
            {
                if (value > 0 && value <= 128)
                {
                    this.deptNo = value;
                }
            }
            get
            {
                return this.deptNo;
            }
        }

        public abstract decimal Basic { get; set; }
        #endregion
        public Employee()
        {
            Console.WriteLine("Employee class no Param Constructor");
        }
        public Employee(string name, short depno) : this()
        {
            Console.WriteLine("Employee class Param Constructor");
            this.EmpNo = ++count;
            this.Name = name;
            this.DeptNo = depno;
        }


        public abstract decimal CalNetSalary();
    }
    public class Manager : Employee
    {
        public Manager(decimal basic) : base("Jack", 2)
        {
            Console.WriteLine("Manager NoParam Constructor");
            this.Basic = basic;
        }
        public override decimal Basic
        {
            get
            {
                return this.basic;
            }
            set
            {
                if (value >= 10000)
                {
                    this.basic = value;
                }
                else
                {
                    Console.WriteLine("Manager salary Should be greater than 10k");
                }
            }
        }

        public override decimal CalNetSalary()
        {
            return this.Basic * 0.05m + 4520;
        }
    }
    public class GeneralManager : Employee
    {
        public GeneralManager(decimal basic) : base("tommy", 1)
        {
            Console.WriteLine("General-Manager NoParam Constructor");
            this.Basic = basic;
        }
        public override decimal Basic
        {
            get
            {
                return this.basic;
            }

            set
            {
                if (value >= 20000)
                {
                    this.basic = value;
                }
                else
                {
                    Console.WriteLine("GeneralManager salary Should be greater than 20k");
                }
            }
        }

        public override decimal CalNetSalary()
        {
            return this.Basic * 0.05m + 10520;
        }
    }
    public class CEO : Employee
    {
        public CEO(decimal basic) : base("Dreak", 2)
        {
            Console.WriteLine("CEO NoParam Constructor");
            this.Basic = basic;
        }
        public override decimal Basic
        {
            get
            {
                return this.basic;
            }

            set
            {
                if (value >= 40000)
                {
                    this.basic = value;
                }
                else
                {
                    Console.WriteLine("CEO salary Should be greater than 40k");
                }
            }
        }

        public override decimal CalNetSalary()
        {
            return this.Basic * 0.05m + 10520;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Employee e1 = new Manager(12000);
            Employee e2 = new GeneralManager(25000);
            Employee e3 = new CEO(450000);
            Console.WriteLine(e1.CalNetSalary());
            Console.WriteLine(e2.CalNetSalary());
            Console.WriteLine(e3.CalNetSalary());
            Console.WriteLine("General Manager : ID : " + e2.EmpNo + " Basic : " + e2.Basic + " Salary "
                + e2.CalNetSalary() + " Dept no " + e2.DeptNo);

        }
    }
}

