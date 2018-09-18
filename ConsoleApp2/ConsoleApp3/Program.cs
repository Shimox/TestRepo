using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> stupidList = new List<String>();
            stupidList.Add("Erik");
            stupidList.Add("Jesper");
            stupidList.Add("Steven");
            int count = 0;

            foreach (var String in stupidList)
            {
                Console.WriteLine($"Denna idiot heter {String}");
                count++;
            }

            stupidList.RemoveAt(1);

            foreach (var String in stupidList)
            {
                Console.WriteLine($"Denna idiot heter {String}");
                count++;
            }
        }
    }
}
