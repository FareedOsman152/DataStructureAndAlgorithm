using Algorithm.Search;

namespace Algorithm;

class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
        
        var searcher = new SortedListBinarySearcher<int>();
        
        var result = searcher.Search(list, 10);
        Console.WriteLine(result);
        Console.WriteLine("Hello, World!");
    }
}