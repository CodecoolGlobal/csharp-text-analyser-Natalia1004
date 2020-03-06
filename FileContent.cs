using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TextAnalyser
{
    class FileContent : IterableText
    {
        public string FileContentAsString { get; set; }
        public string[] FileContentArrayOfWord { get; set; }
        public string fileName {get; private set;}
        

        public FileContent(string path)
        {
            fileName = GetFilename(path);
            FileContentAsString = FileContentReader(fileName);
            FileContentArrayOfWord = FileContentReader(fileName).Split(" ").ToArray();
        }
        
        private static string FileContentReader(string fileName)
        {
            string text = File.ReadAllText(@fileName).Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ");
            return text;
        }
        public string GetFilename(string path)
        {
            fileName = Path.GetFileName(path);
            return fileName;
        }


        public Iterator WordIterator()
        {
            return new WordIterator(this);
        }

        public Iterator CharIterator()
        {
            return new CharIterator(this);
        }
    }
}