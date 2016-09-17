using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[]sentences = text.Split('.','!','?').ToArray();
            char[] separators = new char[] { ' ', ',','-','+','\\','/','(',')'};
            for (int i = 0; i < sentences.Length; i++)
            {
                string newSentence = sentences[i];
                string[] novidumi = newSentence.Split(separators);
                if (novidumi.Contains(word))
                {
                    Console.WriteLine(newSentence.Trim());
                }
            }
            
        }
    }
}
