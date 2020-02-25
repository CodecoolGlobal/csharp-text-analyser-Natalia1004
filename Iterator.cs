using System;
using System.IO;

namespace TextAnalyser
{
    interface ITerator
    {
        bool HasNext();
        string MoveNext();
        void Remove();
    }
}