using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentNo3
{

    public class Emplyee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public Emplyee(int id, string name = "none", int salary = 1000)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return "Employee ID : " + this.Id + " Name : " + this.Name + " Salary : " + this.Salary;
        }

    }
    public class Program
    {
        public static void HishestSalaryEmployee(Emplyee[] arr)
        {
            //Display Employee With highest salary

            Emplyee eMaxSal = arr[0];
            for (int j = 0; j < arr.Length; j++)
            {

                if (arr[j].Salary > eMaxSal.Salary)
                {
                    eMaxSal = arr[j];
                }
            }
            Console.WriteLine("Highest Salary Emplloyee : " + eMaxSal.ToString());
        }

        public static void displayEmployee(Emplyee[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j].ToString());
            }
        }

        public static void takeInput(Emplyee[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Name for Employee {0}", i + 1);
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary for {0}", name);
                int sal = Convert.ToInt32(Console.ReadLine());
                Emplyee e = new Emplyee((i + 1), name, sal);
                arr[i] = e;
                Console.Clear();
            }
        }
        public static void Main()
        {
            Emplyee[] arr = new Emplyee[5];
            takeInput(arr);
            HishestSalaryEmployee(arr);
            displayEmployee(arr);
        }
    }
}

