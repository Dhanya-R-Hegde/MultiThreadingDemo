using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    public class PayrollOperations
    {
        List<Payroll> payrollObj1 = new List<Payroll>();

        public void addEmployee(List<Payroll> payrollObj1)
        {
            payrollObj1.ForEach(payrollData =>
            {
                Console.WriteLine("Employee being added : " + payrollData.EmployeeName);
                this.addEmployeeToList(payrollData);
                Console.WriteLine("Employee added : " + payrollData.EmployeeName);
            });
        }

        public void addEmployeeWithThread(List<Payroll> payrollObj1)
        {
            payrollObj1.ForEach(payrollData =>
            {
                Task Thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added : " + payrollData.EmployeeName);
                    this.addEmployeeToList(payrollData);
                    Console.WriteLine("Employee added : " + payrollData.EmployeeName);
                });
                Thread.Start();
            });
        }

        public void addEmployeeToList(Payroll payroll)
        {
            payrollObj1.Add(payroll);
        }
    }
}
