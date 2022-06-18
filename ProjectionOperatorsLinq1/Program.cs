using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjectionOperatorsLinq1
{
    class Program
    {
        static void Main()
        {
            var result = Employee.GetAllEmployees().Where(x => x.AnnualSalary > 50000)
                .Select(emp => new { Name = emp.FirstName, AnnualSalary = emp.AnnualSalary , Bonus = emp.AnnualSalary * .1 });

            foreach (var v in result)
            {
                Console.WriteLine(v.Name+" :"  + v.AnnualSalary+ " - " + v.Bonus);
            }
        }
    }
}
