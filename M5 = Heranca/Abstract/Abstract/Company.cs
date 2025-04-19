using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Company : People
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double annualIncome, int numberemployees) : base(name, annualIncome)
        {
            NumberEmployees = numberemployees;
        }

        public override double tax()
        {
            if (NumberEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
