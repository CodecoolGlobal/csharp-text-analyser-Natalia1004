using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyser
{
    class CharIterator : ITerator
    {
        public FileContent CharIteratorOf { get; set; }
        public int index {get; private set;}

        public CharIterator(FileContent FileContentAsString)
        {
            CharIteratorOf = FileContentAsString;
            index = 0;
        }

        public bool HasNext()
        {
            if(index < CharIteratorOf.FileContentAsString.Length)
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
            if (HasNext())
            {
                if (Char.IsWhiteSpace(CharIteratorOf.FileContentAsString[index]))
                {
                    index ++;
                    return MoveNext();
                }
                else
                {
                    index ++;
                    return Char.ToString(CharIteratorOf.FileContentAsString[index-1]).ToLower();
                }
            }return null;
        }

        public void Remove()
        {
            index = 0;
        }
    }
}