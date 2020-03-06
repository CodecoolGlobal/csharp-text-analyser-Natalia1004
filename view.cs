using System;
using System.Collections.Generic;

namespace TextAnalyser
{

    public class View
    {
        public void PrintStart()
        {
            Console.WriteLine("Hello, Enter the path to txt file You want to analyze:");
        }

        public void PrintMenuUser()
        {
            Console.WriteLine("Select what you want to check");
            Console.WriteLine("(1) Sum of all occurrences some words or chars: a) Char b) Word");
            Console.WriteLine("(2) Number of unique elements of the dataset: a) Char b) Word");
            Console.WriteLine("(3) Total number of all elements in the dataset: a) Char b) Word");
            Console.WriteLine("(4) All the elements that occur more than...(You have to choose  number): a) Char b) Word");
            Console.WriteLine("(5) The ratio of char1 to char2 occurrences");
            Console.WriteLine("(6) Check the percentage of in whole text of all the letters: a) Char b) Word");
            Console.WriteLine("(0) Quit");
            Console.WriteLine("First, enter number, then letter!(for instance 1a)");

        }
        public void PrintQuit()
        {
            Console.WriteLine("Goodbye !");
        }

         public void Print(string[] list, List<decimal> list2)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list[i] + " -> " + Math.Round(list2[i],2));
            }
            Console.WriteLine();
        }

        public void Print(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> item in dictionary)
            {
                Console.WriteLine($"'{item.Key}' count: {item.Value}");
            }
        }

    }
}