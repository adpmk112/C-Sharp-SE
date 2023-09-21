using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleTest.DateTimeTest
{
    public class GetBetweenDateTest
    {
        public List<DateTime> GetDatesBetween(DateTime startDate, DateTime endDate)
        {
            List<DateTime> datesBetween = new List<DateTime>();

            startDate = startDate.AddDays(1);

            while(startDate < endDate)
            {
                datesBetween.Add(startDate);

                startDate = startDate.AddDays(1); 
            }

            return datesBetween;
        }
    }
}
