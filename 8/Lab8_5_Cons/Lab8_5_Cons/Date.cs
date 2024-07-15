using System;

namespace Lab8_5_Cons
{
    public class Date
    {
        public delegate void InvalidDateEventHandler();
        public event InvalidDateEventHandler InvalidDate;

        public delegate void SuspiciousDateEventHandler();
        public event SuspiciousDateEventHandler SuspiciousDate;

        private static readonly int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly string[] MonthsNames = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        private int day;
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > (Month == 2 && IsLeapYear(Year) ? 29 : DaysInMonth[Month - 1]))
                {
                    OnInvalidDate();
                    return;
                }

                if (value > 28)
                {
                    OnSuspiciousDate();
                }

                day = value;
            }
        }

        private int month;
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    OnInvalidDate();
                    return;
                }

                if (value > 12)
                {
                    OnSuspiciousDate();
                }

                month = value;
            }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value <= 0)
                {
                    OnInvalidDate();
                    return;
                }

                if (value > 2050)
                {
                    OnSuspiciousDate();
                }

                year = value;
            }
        }

        public Date(int day, int month, int year)
        {
            Month = month;  // Сначала устанавливаем месяц и год
            Year = year;
            Day = day;      // Потом устанавливаем день, т.к. он зависит от месяца и года
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        private void OnInvalidDate()
        {
            InvalidDate?.Invoke();
        }

        private void OnSuspiciousDate()
        {
            SuspiciousDate?.Invoke();
        }

        public Date Next()
        {
            var nextDay = Day + 1;
            var nextMonth = Month;
            var nextYear = Year;

            if (nextDay > DaysInMonth[nextMonth - 1] + (nextMonth == 2 && IsLeapYear(nextYear) ? 1 : 0))
            {
                nextDay = 1;
                nextMonth++;
            }

            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear++;
            }

            return new Date(nextDay, nextMonth, nextYear);
        }

        public Date Prev()
        {
            var prevDay = Day - 1;
            var prevMonth = Month;
            var prevYear = Year;

            if (prevDay < 1)
            {
                prevMonth--;
                if (prevMonth < 1)
                {
                    prevMonth = 12;
                    prevYear--;
                }

                prevDay = DaysInMonth[prevMonth - 1] + (prevMonth == 2 && IsLeapYear(prevYear) ? 1 : 0);
            }

            return new Date(prevDay, prevMonth, prevYear);
        }

        public bool IsLeapYear()
        {
            return IsLeapYear(Year);
        }

        public override string ToString()
        {
            return $"{Day} {MonthsNames[Month - 1]} {Year} г.";
        }
    }
}