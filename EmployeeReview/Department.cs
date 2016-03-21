using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReview
{
    class Department
    {
        public Department(string departName)
        {
            this.Name = departName;
        }

        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();


        public void AddEmployee(Employee emp)
        {
            this.Employees.Add(emp);
        }

        public Employee FindEmployee(string employeeName)
        {
            //find in the list of Employees the guy with the name == "EmployeeName"
            return Employees.FirstOrDefault(e => e.Name == employeeName);
        }


        public decimal TotalSalary()
        {
            decimal totalSalary = 0m;
            foreach (var e in Employees)
            {
                totalSalary += e.Salary;
            }
            return totalSalary;
        }

        public void GiveRaise(decimal raise)
        {
            int empEligible = 0;

            foreach (var e in Employees)
            {
                if (e.isSatisfactory)
                {
                    empEligible += 1;
                }
            }

            raise = raise / empEligible;

            foreach (var e in Employees)
            {
                if (e.isSatisfactory)
                {
                    e.Salary += raise;
                }
            }
        }
        public void GiveRaiseToIndividual(decimal raise, Employee e)
        {
            e.Salary += raise;
        }

    }


}
