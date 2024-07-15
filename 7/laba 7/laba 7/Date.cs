using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateLib
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = Math.Max(1, year);
            Normalize();
        }

        public Date(Date other)
        {
            day = other.day;
            month = other.month;
            year = other.year;
        }

        public void Next()
        {
            day++;
            Normalize();
        }

        public void Prev()
        {
            day--;
            Normalize();
        }

        public bool IsLeapYear()
        {
            return IsLeapYear(year);
        }

        public static Date operator +(Date date, int days)
        {
            var newDate = new Date(date);
            newDate.day += days;
            newDate.Normalize();
            return newDate;
        }

        public static Date operator -(Date date, int days)
        {
            var newDate = new Date(date);
            newDate.day -= days;
            newDate.Normalize();
            return newDate;
        }

        public override string ToString()
        {
            return $"{day} {GetMonthName()} {year} г.";
        }

        private string GetMonthName()
        {
            switch (month)
            {
                case 1: return "января";
                case 2: return "февраля";
                case 3: return "марта";
                case 4: return "апреля";
                case 5: return "мая";
                case 6: return "июня";
                case 7: return "июля";
                case 8: return "августа";
                case 9: return "сентября";
                case 10: return "октября";
                case 11: return "ноября";
                case 12: return "декабря";
                default: throw new ArgumentException("Недопустимый номер месяца");
            }
        }

        private void Normalize()
        {
            while (day < 1)
            {
                if (--month < 1)
                {
                    month = 12;
                    year--;
                }
                day += GetDaysInMonth(month, year);
            }

            while (day > GetDaysInMonth(month, year))
            {
                day -= GetDaysInMonth(month, year);
                if (++month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }

        private int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 2: return IsLeapYear(year) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11: return 30;
                default: return 31;
            }
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }

}
