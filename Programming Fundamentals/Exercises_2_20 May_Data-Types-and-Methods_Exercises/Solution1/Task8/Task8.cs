using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Task8
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalId = ulong.Parse(Console.ReadLine());
            uint uniqieEmployeeNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}", firstName,lastName,age,gender,personalId,uniqieEmployeeNumber );
        }
    }
}
