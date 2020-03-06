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
        public Iterator StatisticalAnalysisOf{ get; set; }
        private Iterator Iterator{get; set;}

        public StatisticalAnalysis(Iterator iterator)
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

        public int DictionarySize()
        {
            List<string> UniqueOccurrences = new List<string>();
            while(Iterator.HasNext())
            {
                var currentElem = Iterator.MoveNext();
                {
                    if (!UniqueOccurrences.Contains(currentElem))
                    {
                        UniqueOccurrences.Add(currentElem);
                    }
                }
           
            }return UniqueOccurrences.Count();

        }

        public int Size()
        {
            int NumberOfAllElements = 0;

            while(Iterator.HasNext())
            {
                NumberOfAllElements ++;
                Iterator.MoveNext();
            }
            return NumberOfAllElements;
        }

        public ISet<string> OccurMoreThan(int numberOfTimes)
        {
            HashSet<string> WordsOccur = new HashSet<string>();
            Dictionary<string, int> DictionaryChar = DictionaryText();

            foreach(string Key in DictionaryChar.Keys)
            {
                int values = DictionaryChar[Key];
                if (values > numberOfTimes)
                {
                    WordsOccur.Add(Key);
                }
            }
            return WordsOccur;
        }

        private Dictionary<string, int> DictionaryText()
        {
            Dictionary<string, int> AllCharIterator = new Dictionary<string, int>();
            while(Iterator.HasNext())
            {
                string word = Iterator.MoveNext();

                if(!AllCharIterator.ContainsKey(word))
                {
                    AllCharIterator.Add(word,1);
                }
                else
                {
                    AllCharIterator[word] ++;
                }
            }

            return AllCharIterator;
        }

        public float CountRatio(string FirstWord, string SecondWord)
        {
            return CountOf(FirstWord) / CountOf(SecondWord);
        }
         
        public List<decimal> CharToWholeText(string[] elems)
        {
            List<decimal> percentageCharToWholeText = new List<decimal>();
            foreach(string elem in elems)
            {
                decimal percentage = (decimal) CountOf(elem) / (decimal) Size() * 100;
                percentageCharToWholeText.Add(percentage);

            }    
            return percentageCharToWholeText;
        }
    }
}
