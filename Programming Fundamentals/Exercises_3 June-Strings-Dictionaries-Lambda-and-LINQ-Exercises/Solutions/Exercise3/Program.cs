using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string text = Console.ReadLine();
            string[] splitEmail = email.Split('@').ToArray();
            string domain = new string('*', splitEmail[0].Length) ;
            string replaced = text.Replace(email,domain + "@" + splitEmail[1]);

            Console.WriteLine(replaced);
        }
    }
}
