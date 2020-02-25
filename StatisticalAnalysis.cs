using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace TextAnalyser
{
    class StatisticalAnalysis
    {
        public string nameFile{get; set;}
        public ITerator StatisticalAnalysisOf{ get; set; }
        
        public int CountOf(params string[] words)
        {
            string textFile = "test.txt";
            int CountOfAllOccurrences = 0;
            foreach(string word in words)
            {
                StreamReader LineFileText = new StreamReader(@textFile);
                while (!LineFileText.EndOfStream)
                {
                    string[] lineFromResults = LineFileText.ReadLine().Split(" ");
                    
                    for (int elem = 0; elem < lineFromResults.Length; elem ++ )
                    {
                        if (lineFromResults[elem].Contains(word))
                        {
                            CountOfAllOccurrences ++;
                        }
                    }

                }
            }
            return CountOfAllOccurrences;
        }

        public int DictionarySize(string nameFile)
        {
            string text = File.ReadAllText(@nameFile);
            text = text.ToLower();
            string[] words = text.Split(new char[]{' ', '\n', '\r'});
            string[] UniqueWords = words.Distinct().ToArray();            

            return UniqueWords.Length;

        }

        public int Size(string choice,string nameFile)
        {
            int NumberOfTotal = 0;
            if (choice == "words")
            {
                string text = File.ReadAllText(@nameFile);
                text = text.ToLower();
                string[] words = text.Split(new char[]{' ', '\n', '\r'});
                NumberOfTotal = words.Length;

            }
            else
            {
                string text = File.ReadAllText(@nameFile);
                foreach(char chars in text)
                {
                    NumberOfTotal ++;
                }

            }
            return NumberOfTotal;

        }

        public ISet<string> OccurMoreThan(int numberOfTimes)
        {
            throw new NotImplementedException();
        }
        public string[] ReaderTextFile(string nameFile)
        {
            throw new NotImplementedException();
        }
    }
}