using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticePrograms
{
    public class Employee
    {
        public string Name { get; set; }

        public int Salary { get; set; }
    }

    public class HighestSalaryLinq
    {
        static void Main()
        {
            var employees = new List<Employee>
        {
             new Employee { Name = "A", Salary = 5000 },
             new Employee { Name = "B", Salary = 7000 },
             new Employee { Name = "C", Salary = 7000 },
             new Employee { Name = "D", Salary = 3000 },
             new Employee { Name = "E", Salary = 9000 }
         };

            int n = 3;

            var nthSalary = employees
                .Select(e => e.Salary)
                .Distinct()
                .OrderByDescending(s => s)
                .Skip(n - 1)
                .FirstOrDefault();

            Console.WriteLine(nthSalary);
        }
    }
}
