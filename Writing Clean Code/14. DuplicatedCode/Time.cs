using System;

namespace CleanCode.DuplicatedCode
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public static Time Parse(string dateTimeString)
        {
            int time;
            int hours;
            int minutes;
            if(!string.IsNullOrWhiteSpace(dateTimeString))
            {
                if(int.TryParse(dateTimeString.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("dateTimeString");
                }
            }
            else
                throw new ArgumentException("dateTimeString");

            return new Time(hours, minutes);
        }

    }
}
