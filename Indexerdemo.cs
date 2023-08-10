using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Employee2
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }
    }

    class EmployeeCollection
    {
        private List<Employee2> employees = new List<Employee2>();

       
        public Employee2 this[int id]
        {
            get
            {
                return employees.Find(emp => emp.Id == id);
            }
            set
            {
                var existingEmployee = employees.Find(emp => emp.Id == id);
                if (existingEmployee != null)
                {
                    existingEmployee.Name = value.Name;
                    existingEmployee.Salary = value.Salary;
                }
                else
                {
                    employees.Add(value);
                }
            }
        }
    }

    class Indexerdemo
    {
        static void Main(string[] args)
        {
            EmployeeCollection employeeCollection = new EmployeeCollection();

            employeeCollection[50] = new Employee2 { Id = 101, Name = "Siva", Salary = 20000 };     

            int employeeId = 101;
            Employee2 employee = employeeCollection[employeeId];
            if (employee != null)
            {
                Console.WriteLine($"Employee ID: {employee.Id}");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Salary: {employee.Salary}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {employeeId} not found.");
            }
        }
    }
}
