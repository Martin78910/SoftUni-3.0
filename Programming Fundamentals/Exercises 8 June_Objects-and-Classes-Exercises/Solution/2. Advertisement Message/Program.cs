using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Excellent product", "Such a great product", "I always use that product", "Best product of its category."};
          
            string[] events =
            {"Now I feel good.", "I have succeeded to change.", "That makes miracles.","I cannot believe but now I feel awesome", "Try it yourself, I am very satisfied."};
            string[] author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Misha"};
            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
           
            Random rnd = new Random();
            int messageCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messageCount; i++)
            {
                int phraseIndex = rnd.Next(phrases.Length);
                string randomPhrase = phrases[phraseIndex];

                int eventsIndex = rnd.Next(events.Length);
                string randomEvents = events[eventsIndex];

                int authorsIndex = rnd.Next(author.Length);
                string randomAuthor = author[authorsIndex];

                int cityIndex = rnd.Next(cities.Length);
                string randomCity = cities[cityIndex];

                string message = $"{randomPhrase} {randomEvents} {randomAuthor} - {randomCity}";
                Console.WriteLine(message);
            }
            

        }
    }
}
