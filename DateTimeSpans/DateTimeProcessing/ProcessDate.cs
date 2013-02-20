using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeProcessing
{
    public class ProcessDate
    {
        /*
         * Determines the number of days between two dates and also returns if the dates are in fornight
         * blocks between each other
         * 
         */

        public int CalculateSpanBetweenTwoDates(DateTime d1, DateTime d2, out bool isFortnight)
        {            
            TimeSpan ts = d2 - d1;
            isFortnight = (ts.Days % 14 == 0) ? true : false;
            return ts.Days;
        }
    }
}
