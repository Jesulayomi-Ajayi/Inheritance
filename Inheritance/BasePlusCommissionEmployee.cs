using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class BasePlusCommissionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal commissionRate;
        private decimal baseSalary;

        // six-parameter constructor
        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            GrossSales = sales;
            CommissionRate = rate;
            BaseSalary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
            }
        }

        // property that gets and sets commission employee's commission rate
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate must be > 0 and < 1");
            }
        }

        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary",
                    value, "BaseSalary must be >= 0");
            }
        }


        // calculate commission employee's pay
        public decimal Earnings()
        {
            return baseSalary + (commissionRate * grossSales);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
                "base-salaried commission employee", firstName, lastName,
                "social security number", socialSecurityNumber,
                "gross sales", grossSales,
                "commission rate", commissionRate,
                "base salary", baseSalary);
        }
    }
}
