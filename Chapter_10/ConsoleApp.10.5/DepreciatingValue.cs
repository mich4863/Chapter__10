using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._5
{
    public class DepreciatingValue
    {
        private decimal valueOfAsset;
        private static decimal annualDepreciatingRate = 0.11m;

        public DepreciatingValue(decimal valueOfAsset)
        {
            ValueOfAsset = valueOfAsset;
        }

        public static decimal AnnualDepreciatingRate
        {
            get
            {
                return annualDepreciatingRate;
            }

            set
            {
                annualDepreciatingRate = value;
            }
        }

        public decimal ValueOfAsset
        {
            get
            {
                return valueOfAsset;
            }

            set
            {
                valueOfAsset = value;
            }
        }

        public void CalculateAnnualDepreciation()
        {
            decimal result = ValueOfAsset * AnnualDepreciatingRate;
            ValueOfAsset = ValueOfAsset - result;
        }

        public void CalculateAnnualDepreciationForThreeYears()
        {
            decimal result = ValueOfAsset * AnnualDepreciatingRate * 3;
            ValueOfAsset = ValueOfAsset - result;
        }
    }
}
