using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReview
{
    class Employee
    {
        public Employee(string name, string email, string phone, decimal salary)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Salary = salary;

        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public bool isSatisfactory { get; set; }
        public string employeeReview1 = "";

        public string employeeReview2 = "";

        public void Satisfactory(bool reviewType)
        {
            isSatisfactory = reviewType;
        }
    }
}
