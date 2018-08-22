using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._6
{
    public class Date
    {
        protected static int[] daysPerMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int month;
        private int day;
        private int year;

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
            Console.WriteLine($"Date object constructor for date {this}");
        }

        public int Month
        {
            get
            {
                return month;
            }

            private set
            {
                if(value <= 0 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Month)} must be 1-12");
                }
                month = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }

            private set
            {
                
                
                if(value <= 0 || value > daysPerMonth[Month])
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range current month/year");   
                }

                if(Month == 2 && value == 29 && !(Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range current month/year");
                }

                day = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if(value == 0 || value > 2099)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Year)} out of range");
                }
                year = value;
            }
        }

        /*public void NextDay(int d)
        {
            if(d == daysPerMonth[Month])
            {
                Day = 1;
                Month++;
            }
            else
            {
                Day = Day + 1;
            }   
        }*/

        public void NextDay2(int d, int m)
        {
            if(m == 12 && d == daysPerMonth[Month])
            {
                Year++;
                Month = 1;
                Day = 1;
                return;
            }

            if(d == daysPerMonth[Month])
            {
                Day = 1;
                Month++;
            }
            else
            {
                Day++;
            }
        }

        public override string ToString() => $"{Month}/{Day}/{Year}";
    }
}
