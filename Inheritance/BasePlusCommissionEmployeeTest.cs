using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class BasePlusCommissionEmployeeTest
    {
        public static void Main(string[] args)
        {
            BasePlusCommissionEmployee employee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Employee information obtained by properties and methods: \n");
            Console.WriteLine("First name is {0}", employee.FirstName);
            Console.WriteLine("Last name is {0}", employee.LastName);
            Console.WriteLine("Social security number is {0}", employee.SocialSecurityNumber);
            Console.WriteLine("Gross sales are {0:C}", employee.GrossSales);
            Console.WriteLine("Commission rate is {0:F2}", employee.CommissionRate);
            Console.WriteLine("Earnings are {0:C}", employee.Earnings());
            Console.WriteLine("Base salary is {0:C}", employee.BaseSalary);

            employee.BaseSalary = 1000.00M;

            Console.WriteLine("\n{0}:\n\n{1}", "Updated employee information obtained by ToString", employee);
            Console.WriteLine("earnings: {0:C}", employee.Earnings());

        }
    }
}
