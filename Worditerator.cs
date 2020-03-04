using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyser
{
    class WordIterator : ITerator
    {
        public FileContent WordIteratorOf{ get; set; }
        public int index{get; private set;}

        public WordIterator(FileContent FileContentArrayOfWord)
        {
         index = -1;
         WordIteratorOf = FileContentArrayOfWord;   
        }

    
        public bool HasNext()
        {
            if(index < WordIteratorOf.FileContentArrayOfWord.Length)
            {
                return true;
            }
            else
            {
                index = 0;
                return false;
            }
        }

        public string MoveNext()
        {
            return null;
        }

        public void Remove()
        {
            index = 0;
        }
    }
}