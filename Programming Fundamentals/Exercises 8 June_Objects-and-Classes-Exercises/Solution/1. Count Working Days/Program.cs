using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            var startDate = DateTime.ParseExact(input1,"d-M-yyyy",CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(input2, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays =new DateTime[]
            {
                new DateTime(2016, 1, 1),
                new DateTime(2016, 3, 3),
                new DateTime(2016, 5, 1),
                new DateTime(2016, 5, 6),
                new DateTime(2016, 5, 24),
                new DateTime(2016, 9, 6),
                new DateTime(2016, 9, 22),
                new DateTime(2016, 11, 1),
                new DateTime(2016, 12, 24),
                new DateTime(2016, 12, 25),
                new DateTime(2016, 12, 26),
            };
            int woringDays = 0;
            for (var date = startDate; date <= endDate; date=date.AddDays(1.00))
            {
                DateTime year = new DateTime(2016,date.Month,date.Day);
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(year))
                {
                    woringDays++;
                }
               
            }
            Console.WriteLine(woringDays);
            
        }
    }
}
