using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQListColdWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            // page 154
            List<Weather> daysForcasted = new List<Weather>();
            daysForcasted.Add(new Weather(DaysOfWeek.Monday, 36, 24));
            daysForcasted.Add(new Weather(DaysOfWeek.Tuesday, 35, 28));
            daysForcasted.Add(new Weather(DaysOfWeek.Wednesday, 36, 29));
            daysForcasted.Add(new Weather(DaysOfWeek.Thursday, 36, 27));
            daysForcasted.Add(new Weather(DaysOfWeek.Friday, 38, 27));
            



            // page 156
            var coldDays =
                from forecast in daysForcasted
                where forecast.HighTemp < 40
                select forecast;

            // page 156
            foreach (var forecast in coldDays)
            {
                Console.WriteLine("Cold weather on {0}", forecast.Day);
            }
        }
    }

    enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    class Weather
    {
        public DaysOfWeek Day;
        public int HighTemp;
        public int LowTemp;

        // page 151
        public Weather(DaysOfWeek day, int high, int low)
        {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }
    }
}