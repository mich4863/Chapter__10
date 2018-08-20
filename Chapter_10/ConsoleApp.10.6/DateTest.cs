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
            Date date = new Date(05, 10, 2001);

            // ------------ A --------------
            int count = 20;

            for(int i = 0; i < count;)
            {
                date.NextDay();
                Console.WriteLine(date);
                i++;
            }
            Console.ReadLine();

            // ------------ A --------------

        }
    }
}
