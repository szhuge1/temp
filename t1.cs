using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = totalDays();
            Console.WriteLine("{0}", test);
            var name = Console.ReadLine();
        }

        static int totalDays(){
            DateTime start = new DateTime(2013, 8, 18); ;  //start of date
            DateTime end = new DateTime(2013,8,27);    //end of date
   
            TimeSpan span= end - start; //total date
            int totalDays = (int)span.TotalDays + 1;
            int mon = 0;
            int tue = 0;
            int wed = 0;
            int thu = 0;
            int fri = 0;
            int sat = 0;
            int sun = 0;
   
           //if monday is checked
           mon = CountDays(DayOfWeek.Monday, start, end);
           //if tuesday is checked
           tue = CountDays(DayOfWeek.Tuesday, start, end);
            //if wednesday is checked
            wed = CountDays(DayOfWeek.Wednesday, start, end);
            //if thursday is checked
            thu = CountDays(DayOfWeek.Thursday, start, end);
            //if friday is checked
           fri = CountDays(DayOfWeek.Friday, start, end);
            //if saturday is checked
            sat = CountDays(DayOfWeek.Saturday, start, end);
            //if sunday is checked
            sun = CountDays(DayOfWeek.Sunday, start, end);
   
            int result = totalDays - mon - tue - wed - thu - fri - sat - sun;
   
            return result;
     }
 
     static int CountDays(DayOfWeek day, DateTime start, DateTime end)
        {
            TimeSpan ts = end - start;                       // Total duration
            int count = (int)Math.Floor(ts.TotalDays / 7);   // Number of whole weeks
            int remainder = (int)(ts.TotalDays % 7);         // Number of remaining days
            int sinceLastDay = (int)(end.DayOfWeek - day);   // Number of days since last [day]
            if (sinceLastDay < 0) sinceLastDay += 7;         // Adjust for negative days since last [day]

            // If the days in excess of an even week are greater than or equal to the number days since the last [day], then count this one, too.
            if (remainder >= sinceLastDay) count++;          

            return count;
        }
    }
}
