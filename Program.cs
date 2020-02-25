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
            
            Console.WriteLine(NumberOfSomeWords.Size("chars", "test.txt"));

        }
    }
}
