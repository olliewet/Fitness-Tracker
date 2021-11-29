using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackHealthAndFitness.Helpers
{
    public class DateHelper
    {
        public static string RemoveTime(string date)
        {
            // Remove a substring from the middle of the string.
            string toRemove = "00:00:00";
            string result = string.Empty;
            int i = date.IndexOf(toRemove);
            if (i >= 0)
            {
                result = date.Remove(i, toRemove.Length);
            }
            return result;
        }
        /// <summary>
        /// Returns the assoicated day of the week
        /// </summary>
        /// <param name="Date"></param>
        /// <returns></returns>
        public static DayOfWeek intToDay(int Date)
        {
            DayOfWeek dayofWeek = DayOfWeek.Monday;
            switch (Date)
            {
                case 1:
                    dayofWeek = DayOfWeek.Monday;
                    break;

                case 2:
                    dayofWeek = DayOfWeek.Tuesday;
                    break;

                case 3:
                    dayofWeek = DayOfWeek.Wednesday;
                    break;

                case 4:
                    dayofWeek = DayOfWeek.Thursday;
                    break;

                case 5:
                    dayofWeek = DayOfWeek.Friday;
                    break;

                case 6:
                    dayofWeek = DayOfWeek.Saturday;
                    break;

                case 7:
                    dayofWeek = DayOfWeek.Sunday;
                    break;
            }
            return dayofWeek;
        }
    }
}
