using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Individual : People
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthexpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double tax()
        {
            if (AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
