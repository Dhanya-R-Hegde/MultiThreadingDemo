using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    public class Payroll
    {
        public int EmployeeID { get; set; }
        
        public string EmployeeName { get; set; }    

        public int EmployeeAge { get; set; }

        public int EmployeeSalary { get; set; }

        public Payroll(int EmployeeID, string EmployeeName, int EmployeeAge, int EmployeeSalary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.EmployeeAge = EmployeeAge;
            this.EmployeeSalary = EmployeeSalary;
        }

    }
}
