using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._3
{
    class HemisphereTest
    {
        static void Main(string[] args)
        {
            Hemisphere hemisphere = new Hemisphere();
            double test = hemisphere.Volume;
            Console.WriteLine($"The volume af the hemisphere is: {test}");

            double test2 = hemisphere.TotalSurfaceArea;
            Console.WriteLine($"The total surface area of the hemisphere is: {test2}");

            double test3 = hemisphere.CurvedSurfaceArea;
            Console.WriteLine($"The total surface area of the hemisphere is: {test3}");
            Console.ReadLine();
        }
    }
}
