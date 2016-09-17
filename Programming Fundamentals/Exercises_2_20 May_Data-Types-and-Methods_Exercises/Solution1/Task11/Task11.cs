using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Task11
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float distanceInMiles = distance/1609f;
            float timeInSeconds = hours*3600+minutes*60+seconds;
            float kilometers = distance/1000;
            float timeInHours = hours+minutes/60f+seconds/60f/60f;
            Console.WriteLine(distance/timeInSeconds);
            Console.WriteLine(kilometers/timeInHours);
            Console.WriteLine(distanceInMiles/timeInHours);

            
        }
    }
}
