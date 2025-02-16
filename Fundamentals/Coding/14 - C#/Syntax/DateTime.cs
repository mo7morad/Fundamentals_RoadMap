
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
    {
        internal class Program
        {

        static void Main(string[] args)
            {

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            //assigns default value 01/01/0001 00:00:00
            DateTime dt5 = new DateTime();
            dt5 = DateTime.Now;

            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 
            DateTime dt6 = new DateTime();

            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: "+currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            Console.WriteLine("----------------------");
            Console.WriteLine("DateTime timespan");
            Console.WriteLine("----------------------");
            DateTime dt7 = new DateTime(2023,2,21);
            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt7.Add(ts);
            Console.WriteLine(newDate);

            Console.WriteLine("----------------------");
            Console.WriteLine("DateTime Properties");
            Console.WriteLine("----------------------");
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            Console.WriteLine(dt5);
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks

            //DateTime Subtraction
            Console.WriteLine("----------------------");
            Console.WriteLine("DateTime Subtraction");
            Console.WriteLine("----------------------");
            DateTime dt8 = new DateTime(2023, 2, 21);
            DateTime dt9 = new DateTime(2023, 2, 25);
            TimeSpan result = dt9.Subtract(dt8);
            Console.WriteLine(result.Days);

            // DateTime Comparison
            Console.WriteLine("----------------------");
            Console.WriteLine("DateTime Comparison");
            Console.WriteLine("----------------------");
            DateTime dt10 = new DateTime(2015, 12, 20);
            DateTime dt11 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt11 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt11 - dt10); //377.05:10:20
            Console.WriteLine(dt10 == dt11); //False
            Console.WriteLine(dt10 != dt11); //True
            Console.WriteLine(dt10 > dt11); //False
            Console.WriteLine(dt10 < dt11); //True
            Console.WriteLine(dt10 >= dt11); //False
            Console.WriteLine(dt10 <= dt11);//True

            //String to DateTime
            Console.WriteLine("----------------------");
            Console.WriteLine("String to DateTime");
            Console.WriteLine("----------------------");

            var str = "6/12/2023";
            DateTime DtFromStr;

            var isValidDate = DateTime.TryParse(str, out DtFromStr);

            if (isValidDate)
                Console.WriteLine(DtFromStr);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime DtFromStr2;

            var isValidDate2 = DateTime.TryParse(str2, out DtFromStr2);

            if (isValidDate2)
                Console.WriteLine(DtFromStr2);
            else
                Console.WriteLine($"{str2} is not a valid date string");

            }
        }
    }
