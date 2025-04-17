using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employees
    {
        

        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employees()
        {
        }

        public Employees(string name, int id, double salary)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
        }

        public void SalaryIncrease(double percentage)
        {
            Salary += Salary * percentage / 100.00; 
        }
    }
}
