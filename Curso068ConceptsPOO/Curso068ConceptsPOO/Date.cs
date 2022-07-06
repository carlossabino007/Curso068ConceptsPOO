using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso068ConceptsPOO
{
    public class Date
    {
        private  int _year;
        private int _month;
        private int _day;

        public Date( int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year,month, day);
        }

        private int CheckDay(int year, int month, int day)
        {
            //365.25.....
            // cada 4 años: si, pero cada 100:no, pero cada 400:si
            // 2000 es multiplo de 100: no es bisiesto. pero 2000 es múltipo de 400: es bisiesto
            if (month == 2 && day == 29 && IsLeepYear(year))
            { return day; }

            int[] daysPerMonth = { 0,31,28,31,30,31,30,31,31,30,31,30,31};
            if (day >= 1 && day <= daysPerMonth[month])
            { return day; }

            throw new DayException($"Invalid day {day}");
        }

        private bool IsLeepYear(int year)
        {

            //if (year % 4 == 0)  /* Si es múltiplo de 4 */
            //{  if (year % 100 == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else 
            //        {
            //            return false;
            //        }

            //    }
            //    else 
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            // return false;
            //}

            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0; 
            /* Si es múdulo de 400  es bisiesto
             * ó
             * que el año sea múltiplo de 4 y no sea múltiplo de 100*/

             

        }

        private int CheckDay(int day)
        {

            throw new NotImplementedException();
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12) { return month;  }
            throw new MonthException($"Invalid Month {month}");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
    
        }
    }

 
}
