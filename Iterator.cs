using System;
using System.IO;

namespace TextAnalyser
{
    interface Iterator
    {
        bool HasNext();
        string MoveNext();
        void Remove();
    }
}