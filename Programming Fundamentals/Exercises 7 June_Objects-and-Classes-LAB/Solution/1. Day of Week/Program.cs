using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            var newDate = DateTime.ParseExact(date, "d-M-yyyy",
  CultureInfo.InvariantCulture);
            Console.WriteLine(newDate.DayOfWeek);


        }
    }
}
