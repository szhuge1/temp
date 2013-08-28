 
 static int totalDays(){
   DateTime start = "2013-08-26"; //start of date
   DateTime end = "2013-08-30"; //end of date
   
   TimeSpan span= start - end; //total date
   int totalDays = (int)span.TotalDays;
   int mon = 0;
   int tue = 0;
   int wed = 0;
   int thu = 0;
   int fri = 0;
   int sat = 0;
   int sun = 0;
   
   //if monday is checked
   int mon = CountDays("Monday", start, end);
   //if tuesday is checked
   int tue = CountDays("Tuesday", start, end);
    //if wednesday is checked
   int wed = CountDays("Wednesday", start, end);
    //if thursday is checked
   int thu = CountDays("Thursday", start, end);
    //if friday is checked
   int fri = CountDays("Friday", start, end);
    //if saturday is checked
   int sat = CountDays("Saturday", start, end);
    //if sunday is checked
   int sun = CountDays("Sunday", start, end);
   
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
