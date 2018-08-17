using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._3
{
    class Hemisphere
    {
        private double radius = 1;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if(value > 0.0 && value < 12.0)
                {
                    radius = value;
                }
            }
        }

        public double Volume
        {
            get
            {
                double result = 1.33333333333 * Math.PI * Math.Pow(Radius, 3);
                return result;
            }
        }

        public double CurvedSurfaceArea
        {
            get
            {
                double result = 2 * Math.PI * Math.Pow(Radius, 2);
                return result;
            }
        }

        public double TotalSurfaceArea
        {
            get
            {
                double result = 4 * Math.PI * Math.Pow(Radius, 2);
                return result;
            }
        }
    }
}
