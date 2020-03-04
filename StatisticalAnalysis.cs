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
        private ITerator Iterator{get; set;}

        public StatisticalAnalysis(ITerator iterator)
        {
            Iterator = iterator;

        }
        
        public int CountOf(params string[] words)
        {
            int CountOfAllOccurrences = 0;
            while(Iterator.HasNext())
            {
                var currentElem = Iterator.MoveNext();
                foreach(string word in words)
            {
                if (currentElem ==  word)
                {
                    CountOfAllOccurrences ++;
                }
            }
           
            }
            Iterator.Remove();
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

        public ISet<string> OccurMoreThan(int numberOfTimes,string nameFile)
        {
            HashSet<string> WordsOccur = new HashSet<string>();
            string text = File.ReadAllText(@nameFile);
            text = text.ToLower();
            string[] words = text.Split(new char[]{' ', '\n', '\r'});
            Dictionary<string,int> countUniqueWords = new Dictionary<string, int>();
            foreach(string word in words)
            {
                if(!countUniqueWords.ContainsKey(word))
                {
                    countUniqueWords.Add(word,1);
                }
                else
                {
                    countUniqueWords[word] ++;
                }
            }
            foreach(string Key in countUniqueWords.Keys)
            {
                if (countUniqueWords[Key] > numberOfTimes)
                {
                    WordsOccur.Add(Key);
                }
            }
            return WordsOccur;
            

        }
    
    }
}