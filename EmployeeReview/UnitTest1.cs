using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeReview
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateADepartmentWithName()
        {
            //Arrange (and also Act)
            Department d = new Department("BEE Students");

            //Assert
            Assert.AreEqual("BEE Students", d.Name);

        }

        [TestMethod]
        public void CreateANewEmployeeWithInfo()
        {
            var emp = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            Assert.AreEqual("Kevin", emp.Name);
            Assert.AreEqual("abc@gmail.com", emp.Email);
            Assert.AreEqual("501999999", emp.Phone);
            Assert.AreEqual(10000m, emp.Salary);
        }

        [TestMethod]
        public void AddAnEmployeeToADepartment()
        {
            var emp = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            Department d = new Department("BEE Students");
            d.AddEmployee(emp);

            Assert.AreEqual(emp, d.FindEmployee("Kevin"));
            Assert.IsNull(d.FindEmployee("DNE"));
        }



        [TestMethod]
        public void AddAnEmployee()
        {
            var emp = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            Department d = new Department("BEE Students");
            d.Employees.Add(emp);
            Assert.AreEqual("Kevin", d.Employees[0].Name);
        }

        [TestMethod]
        public void GetEmployeeSalary()
        {
            var emp = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            Department d = new Department("BEE Students");
            d.Employees.Add(emp);
            Assert.AreEqual(10000m, d.Employees[0].Salary);
        }

        [TestMethod]
        public void GetDepartmentName()
        {
            Department d = new Department("BEE Students");
            Assert.AreEqual("BEE Students", d.Name);
        }

        [TestMethod]
        public void TotalSalaryForAllEmployee()
        {
            var emp = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            var d = new Department("BEE Students");
            d.Employees.Add(emp);

            Assert.AreEqual(10000m, d.TotalSalary());
        }

        [TestMethod]
        public void AddEmployeeReview()
        {
            var emp = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            var d = new Department("BEE Students");
            d.Employees.Add(emp);
            string review1 = "The guy is a good worker. He demonstrates the ability" +
                                 "to show up on time, get ahead on work, and shows the signs" +
                                 "of a good leader. He has worked for the company for at least" +
                                 "3 years with no prior record of bad marks against him.";
            d.Employees[0].employeeReview1 = review1;
            emp.Satisfactory(true);
            Assert.AreEqual(true, emp.isSatisfactory);
            Assert.AreEqual(review1, emp.employeeReview1);
        }

        [TestMethod]
        public void GiveRaise()
        {
            var emp = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            var emp2 = new Employee("Kevin", "abc@gmail.com", "501999999", 10000m);
            var d = new Department("BEE Students");
            d.Employees.Add(emp);
            d.Employees.Add(emp2);
            emp.isSatisfactory = true;
            emp2.isSatisfactory = false;
            d.GiveRaise(1000m);
            Assert.AreEqual(11000m, emp.Salary);
            Assert.AreEqual(10000m, emp2.Salary);
        }

    }
}
