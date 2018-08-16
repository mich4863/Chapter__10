using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._3
{
    class Hemisphere
    {
        private decimal radius;

        public Hemisphere(decimal radius)
        {
            Radius = radius;
        }

        public decimal Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if(value > 0.0m && value < 12.0m)
                {
                    radius = value;
                }
            }
        }

        public decimal Volume
        {
            get;
        }

        public decimal CurvedSurfaceArea
        {
            get;
        }

        public decimal TotalSurfaceArea
        {
            get;
        }
    }
}
