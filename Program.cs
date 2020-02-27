using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Diagnostics;




namespace TextAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            StatisticalAnalysis NumberOfSomeWords = new StatisticalAnalysis();
    
            foreach(string word in NumberOfSomeWords.OccurMoreThan(10, "test.txt"))
            {
                Console.WriteLine(word);
            }
            

        }
    }
}
