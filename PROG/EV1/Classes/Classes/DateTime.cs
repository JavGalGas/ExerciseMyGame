using Microsoft.VisualBasic;
using System;

namespace Classes
{
    public class DateTime
    {
        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minute;
        private int _second;

        public DateTime()
        {
            _year = 0;
            _month = 1;
            _day = 1;
            _hour = 0;
            _minute = 0;
            _second = 0;
        }
        public DateTime(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        public DateTime(int hour, int minute, int second, int day, int month, int year)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
            _day = day;
            _month = month;
            _year = year;
        }
        //public DateTime Clone()
        //{
        //    DateTime date = new DateTime();
        //    date._year = _year;
        //    date._month = _month;
        //    date._day = _day;
        //    date._hour = _hour;
        //    date._minute = _minute;
        //    date._second = _second;
        //    return date;
        //}
        //public bool Equals(DateTime date)
        //{
        //    return (_day==date._day && _month==date._month && _year==date._year && _hour == date._hour && _minute == date._minute && _second == date._second) ? true : false;
        //}
        public bool IsValid()
        {
            if (_year < 0 || _month < 0 || _month > 12 || _day < 0 || _hour < 0 || _minute < 0 || _second < 0)
            {
                return false;
            }
            switch(_month)
            {
                case 2:
                    if (_day > 29 || (_day==29 && !IsLeap())) 
                    {
                        return false; 
                    }
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 11:
                        if (_day > 31) { return false; }
                        break;
                case 4:
                case 6:
                case 8:
                case 10:
                case 12:
                    if (_day > 30) { return false; }
                    break;
                default:
                    break;
                    
            }
            if (_hour < 24 && _minute < 60 && _second < 60) 
            { 
                return true; 
            }
            return false;
        }
        public bool IsLeap()
        {
            return true;
        }
        public static void IsLeap(int year)
        {

        }
        //Getters();

        public string ToString() // escribir la fecha --> (ejemplo): 13/11/2023
        {
            string hola = "hola";
            return hola;
        }
        public int GetDaysCount(int year, int month)
        {
            return _day + 1;
        }
        public void IncrementDay()
        {
            if(IsValid())
                _day++;
            if(!IsValid())
            {
                if(_month<=12)
                {
                    _day = 1;
                    _month++;
                }
                _day = 1;
                _month=1;
                _year++;
            }
        }
        //public void IncrementSeconds()
        //{
        //    if (IsValid())
        //        _second++;
        //    if (!IsValid())
        //    {
        //        if (_minute <= 60)
        //        {
        //            _second = 0;
        //            _minute++;
        //        }
        //        else if ()
                
        //    }
        //}
        public int monthCode()
        {
            switch(_month)
            {
                case 1:
                case 10:
                    return 6;
                case 2:
                case 3:
                case 11:
                    return 2;
                case 4:
                case 7:
                    return 5;
                case 5:
                    return 0;
                case 6:
                    return 3;
                case 9:
                case 12:
                    return 4;
            }
            return 1;
        }
        public int yearCode() // revisar
        {
            int i = _year;
            int leap = i / 400;
            int notLeap = (i / 100) - leap;
            int aux = i - (leap * 100) - (notLeap * 100);
            int aux2 = aux/12 + ((aux%12));
            int aux3 = aux2 % 4;
            int yearCode = (aux2 + aux3)%7;
            int code = leap + (notLeap * 2) + yearCode;
            return code;
        }
        public int weekCode()
        {
            int code = (_day % 7) + monthCode() + yearCode();
            if (IsLeap() && (_month==1 || _month==2))
                code--;
            return code;
        }
        public DayOfWeek GetDayOfWeek()
        {
            switch(weekCode()%7)
            {
                case 0: return DayOfWeek.Monday;
                case 1: return DayOfWeek.Tuesday;
                case 2: return DayOfWeek.Wednesday;
                case 3: return DayOfWeek.Thursday;
                case 4: return DayOfWeek.Friday;
                case 5: return DayOfWeek.Saturday;
            }
            return DayOfWeek.Sunday;
        }
    }
}
