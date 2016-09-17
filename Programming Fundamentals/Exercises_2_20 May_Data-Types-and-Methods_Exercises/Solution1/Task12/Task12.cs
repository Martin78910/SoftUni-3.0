using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Task12
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (2 * width) + (2 * height);
            double diagonal = Math.Sqrt((width*width)+(height*height));
            Console.WriteLine("{0}\n{1}\n{2}",perimeter,area, diagonal);
        }
    }
}
