using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Student : IStudent
    {
        private string stname;
        private int stmoney;
        private int styearsLearnt;
        
        public Student() { }
        public void Stud(string name, int money, int yearsLearnt)
        {
            stname = name;
           stmoney = money;
           styearsLearnt = yearsLearnt;
           
        }
        public void Name(string name)
        {
           stname = name;
        }

        
        public string GetName { get { return stname; } }
        public int GetPaymentStudy { get { return stmoney; } }
        public int GetYearStudy { get { return styearsLearnt; } }
        
    }
}
