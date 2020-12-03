using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3
{
    public interface IDbFunction
    {
        void insert();
        void select();
        void update();
        void delete();
    }
    public abstract class Employee : IDbFunction
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
        public Employee(string name, short depno, decimal basic) : this()
        {
            Console.WriteLine("Employee class Param Constructor");
            this.EmpNo = ++count;
            this.Name = name;
            this.DeptNo = depno;
            this.Basic = basic;
        }

        public abstract void select();
        public abstract void update();
        public abstract void delete();
        public abstract void insert();
        public abstract decimal CalNetSalary();
    }
    public class Manager : Employee
    {
        string designation;
        public Manager(string name = "JAMES", short depno = 11, decimal basic = 10000, string designation = "HR") : base(name, depno, basic)
        {
            Console.WriteLine("Manager NoParam Constructor");
            this.Designation = designation;
        }
        public string Designation
        {
            get { return this.Designation; }
            set
            {
                if (value != "")
                {
                    this.designation = value;
                }
                else
                {
                    Console.WriteLine("Designation cant be null");
                }
            }
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

        public override void select()
        {
            Console.WriteLine("Manager Select Query");
        }

        public override void update()
        {
            Console.WriteLine("Manager update Query");
        }

        public override void delete()
        {
            Console.WriteLine("Manager delete Query");
        }

        public override void insert()
        {
            Console.WriteLine("Manager Insert Query");
        }
    }
    public class GeneralManager : Employee
    {
        public string Perk { get; set; }
        public GeneralManager(string name, short depno, decimal basic, string perk = "none") : base(name, depno, basic)
        {
            Console.WriteLine("GeneralManager NoParam Constructor");
            this.Perk = perk;
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

        public override void select()
        {
            Console.WriteLine("GeneralManager select Query");
        }

        public override void update()
        {
            Console.WriteLine("GeneralManager update Query");
        }

        public override void delete()
        {
            Console.WriteLine("GeneralManager delete Query");
        }

        public override void insert()
        {
            Console.WriteLine("GeneralManager insert Query");
        }
    }
    public class CEO : Employee
    {
        public CEO(string name, short depno, decimal basic) : base(name, depno, basic)
        {
            Console.WriteLine("Manager NoParam Constructor");
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

        public override void delete()
        {
            Console.WriteLine("CEO delete Query");
        }

        public override void insert()
        {
            Console.WriteLine("CEO insert Query");
        }

        public override void select()
        {
            Console.WriteLine("CEO select Query");
        }

        public override void update()
        {
            Console.WriteLine("CEO update Query");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Employee e1 = new Manager("jack", 2, 8000);
            e1.insert();

            Console.WriteLine(e1.CalNetSalary());

            Console.WriteLine("General Manager : ID : " + e1.EmpNo + " Basic : " + e1.Basic + " Salary "
                + e1.CalNetSalary() + " Dept no " + e1.DeptNo);

        }
    }
}

