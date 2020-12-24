using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Stud("PSR", 21234, 3, 12);
            Console.WriteLine("Name: " + student.GetName);
            Console.WriteLine("Year study: " + student.GetYearStudy);
            Console.ReadLine();
        }
    }
}
