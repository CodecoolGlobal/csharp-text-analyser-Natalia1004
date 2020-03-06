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
            
            View PrintFunction = new View();

            PrintFunction.PrintStart();
            //string NameFile = Console.ReadLine();
            string NameFile = "/Users/nataliafilipek/Desktop/OOP/csharp-text-analyser-Natalia1004/test2.txt";

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileContent AnalyzedText = new FileContent(NameFile);
            StatisticalAnalysis AnalazedChar = new StatisticalAnalysis(AnalyzedText.CharIterator());
            StatisticalAnalysis AnalazedWord = new StatisticalAnalysis(AnalyzedText.WordIterator());

            PrintFunction.PrintMenuUser();
            string UserChoice = null;
            
            while (UserChoice != "0")
            {   
                Console.WriteLine("What do You want to do now?");
                UserChoice = Console.ReadLine();

                if (UserChoice == "1a")
                {
                    Console.WriteLine("List of Chars:");
                    var chars = Console.ReadLine();
                    var arrayChars = chars.Split(",");
                    Console.WriteLine(AnalazedChar.CountOf(arrayChars));
                    continue;
                }
                else if (UserChoice == "1b")
                {
                    Console.WriteLine("List of Words:");
                    var words = Console.ReadLine();
                    var arrayWords = words.Split(",");
                    Console.WriteLine(AnalazedWord.CountOf(arrayWords));
                    continue;
                }
                else if (UserChoice == "2a")
                {
                    Console.WriteLine("All of unique chars is:");
                    Console.WriteLine(AnalazedChar.DictionarySize());
                    continue;
                }
                else if (UserChoice == "2b")
                {
                    Console.WriteLine("All of unique words is:");
                    Console.WriteLine(AnalazedWord.DictionarySize());
                    continue;
                }
                else if (UserChoice == "3a")
                {
                    Console.WriteLine("Total nmber of chars is:");
                    Console.WriteLine(AnalazedChar.Size());
                    continue;
                }
                else if (UserChoice == "3b")
                {
                    Console.WriteLine("Total nmber of words is:");
                    Console.WriteLine(AnalazedWord.Size());
                    continue;
                }
                else if (UserChoice == "4a")
                {
                    Console.WriteLine("Select number of occurences:");
                    int NumberOccurences = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AnalazedChar.OccurMoreThan(NumberOccurences));
                    continue;
                }
                else if (UserChoice == "4b")
                {
                    Console.WriteLine("Select number of occurences:");
                    int NumberOccurences = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AnalazedWord.OccurMoreThan(NumberOccurences));
                    continue;
                }
                else if (UserChoice == "5")
                {
                    Console.WriteLine("Select first and second char");
                    string first = Console.ReadLine();
                    string second = Console.ReadLine();
                    Console.WriteLine(AnalazedChar.CountRatio(first, second));
                }
                if (UserChoice == "6a")
                {
                    Console.WriteLine("List of Chars:");
                    var chars = Console.ReadLine();
                    var arrayChars = chars.Split(",");
                    PrintFunction.Print(arrayChars,AnalazedChar.CharToWholeText(arrayChars));
                    continue;
                }
                else if (UserChoice == "6b")
                {
                    Console.WriteLine("List of Words:");
                    var words = Console.ReadLine();
                    var arrayWords = words.Split(",");
                    Console.WriteLine(AnalazedWord.CharToWholeText(arrayWords));
                    continue;
                }   
            
            }
            PrintFunction.PrintQuit();

            stopwatch.Stop();  
            TimeSpan stopwatchElapsed = stopwatch.Elapsed;
            Console.WriteLine(stopwatchElapsed); 
            
        }
    }

}
