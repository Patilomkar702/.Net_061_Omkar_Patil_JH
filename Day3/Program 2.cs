using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDAC
{
    class Program
    {
        public static int[][][] insertData()
        {
            Console.WriteLine("Enter Number of Batches for CDAC");
            int bacth = Convert.ToInt32(Console.ReadLine());
            int[][][] cdac = new int[bacth][][];
            for (int batchno = 0; batchno < bacth; batchno++)
            {
                Console.WriteLine("Enter Number of Student for Batch {0}", batchno + 1);
                int students = Convert.ToInt32(Console.ReadLine());
                int[][] arrStudents = new int[students][];
                for (int studentno = 0; studentno < students; studentno++)
                {
                    int[] arrSubject = new int[3];
                    for (int subjetNo = 0; subjetNo < arrSubject.Length; subjetNo++)
                    {
                        Console.Write("Enter Marks of Studen {0} for Subject {1} ", studentno + 1, subjetNo + 1);
                        int subMarks = Convert.ToInt32(Console.ReadLine());
                        arrSubject[subjetNo] = subMarks;

                    }
                    arrStudents[studentno] = arrSubject;
                    Console.WriteLine();

                }
                cdac[batchno] = arrStudents;
                Console.Clear();
            }
            return cdac;
        }

        public static void display(int[][][] cdac)
        {
            for (int i = 0; i < cdac.Length; i++)
            {
                Console.WriteLine("Batch {0}", i + 1);
                for (int j = 0; j < cdac[i].Length; j++)
                {
                    Console.WriteLine("Marks for Student {0}", j + 1);
                    for (int k = 0; k < cdac[i][j].Length; k++)
                    {
                        Console.Write(cdac[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[][][] cdac = insertData();
            display(cdac);
        }
    }
}
