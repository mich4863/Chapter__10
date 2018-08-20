using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._10._6
{
    public class Date
    {
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
                int[] daysPerMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

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

        public void NextDay()
        {
            Day = Day + 1;
        }

        public override string ToString() => $"{Month}/{Day}/{Year}";
    }
}
