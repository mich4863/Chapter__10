using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._5
{
    class DepreciatingValueTest
    {
        static void Main(string[] args)
        {
            DepreciatingValue asset1 = new DepreciatingValue(5000000);
            DepreciatingValue asset2 = new DepreciatingValue(6000000);
            DepreciatingValue asset3 = new DepreciatingValue(7000000);

            // --------------------Deducting for one years with 10%-----------------
            /*Console.WriteLine($"Asset1 before deducting 10%: {asset1.ValueOfAsset:C}");
            asset1.CalculateAnnualDepreciation();
            Console.WriteLine($"Asset1 after deducting 10%: {asset1.ValueOfAsset:C}\n");

            Console.WriteLine($"Asset2 before deducting 10%: {asset2.ValueOfAsset:C}");
            asset2.CalculateAnnualDepreciation();
            Console.WriteLine($"Asset2 after deducting 10%: {asset2.ValueOfAsset:C}\n");

            Console.WriteLine($"Asset3 before deducting 10%: {asset3.ValueOfAsset:C}");
            asset3.CalculateAnnualDepreciation();
            Console.WriteLine($"Asset3 after deducting 10%: {asset3.ValueOfAsset:C}\n");*/

            // --------------------Deducting for three years with 11%-----------------
            Console.WriteLine($"Asset1 before deducting 11% for three years: {asset1.ValueOfAsset:C}");
            asset1.CalculateAnnualDepreciationForThreeYears();
            Console.WriteLine($"Asset1 after deducting 11% for three years: {asset1.ValueOfAsset:C}\n");

            Console.WriteLine($"Asset2 before deducting 11% for three years: {asset2.ValueOfAsset:C}");
            asset2.CalculateAnnualDepreciationForThreeYears();
            Console.WriteLine($"Asset2 after deducting 11% for three years: {asset2.ValueOfAsset:C}\n");

            Console.WriteLine($"Asset3 before deducting 11% for three years: {asset3.ValueOfAsset:C}");
            asset3.CalculateAnnualDepreciationForThreeYears();
            Console.WriteLine($"Asset3 after deducting 11% for three years: {asset3.ValueOfAsset:C}");
            Console.ReadLine();
        }
    }
}
