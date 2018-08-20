using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._6
{
    class DateTest
    {
        static void Main(string[] args)
        {
            //Date date = new Date(05, 20, 2001);

            // ------------ A --------------
            /*int count = 31;

            for(int i = 0; i < count;)
            {
                date.NextDay(date.Day);
                Console.WriteLine(date);
                i++;  
            }
            Console.ReadLine();*/

            // ------------ B --------------

            Date date2 = new Date(07, 07, 2017);

            int count2 = 365;

            for(int i2 = 0; i2 < count2;)
            {
                date2.NextDay2(date2.Day, date2.Month);
                Console.WriteLine(date2);
                i2++;
            }
            Console.ReadLine();
        }
    }
}
