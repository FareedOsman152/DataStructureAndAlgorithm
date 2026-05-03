namespace Algorithm.Search;

public class SortedListBinarySearcher<T> where T : IComparable<T>
{
    public T Search(List<T> list, T e)
    {
        if (list is { Count: < 1 })
            throw new ArgumentException("The list is empty");
        int start = 0;
        int end = list.Count - 1;
        
        while (start <= end)
        {
            int mid = (start + end) / 2;
            T midValue = list[mid];
            if (midValue.Equals(e))
                return list[mid];
            
            if (e.CompareTo(midValue) == -1)
                end = mid - 1;
            else
                start = mid + 1;
        }
        throw new ArgumentException("The element doesn't exist in the list");
    }
}