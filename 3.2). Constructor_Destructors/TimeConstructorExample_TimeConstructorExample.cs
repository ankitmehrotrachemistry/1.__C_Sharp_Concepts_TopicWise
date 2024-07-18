﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConstructorExample
{
    public class Time
    {
        // public accessor methods
        public void DisplayCurrentTime()
        {
            System.Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}",
               Month, Date, Year, Hour, Minute, Second);
        }

        // constructor
        public Time(System.DateTime dt)
        {

            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }

        // private member variables
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second;

    }

    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();
        }
    }
}
