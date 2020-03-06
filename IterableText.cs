
namespace TextAnalyser
{
    interface IterableText
    {
        Iterator CharIterator();
        Iterator WordIterator();
    }
}