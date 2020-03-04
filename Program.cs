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
            FileContent Char = new FileContent("/Users/nataliafilipek/Desktop/OOP/csharp-text-analyser-Natalia1004/test2.txt");
            StatisticalAnalysis Occur = new StatisticalAnalysis(Char.CharIterator());
            Console.WriteLine(Occur.DictionarySize("test2.txt"));
        }
    }

}
