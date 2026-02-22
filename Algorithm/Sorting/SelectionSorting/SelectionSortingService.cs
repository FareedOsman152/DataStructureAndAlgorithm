namespace Algorithm.Sorting.SelectionSorting;

public abstract class SelectionSortingService <T> where T : IComparable<T>
{
    public static void Sort(List<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        if (collection.Count < 2)
            return;
        
        ActualSort(collection);
    }

    private static void ActualSort(List<T> collection)
    {
        var endIndex = collection.Count - 1;
        while (true)
        {
            var biggestElementIndex = 0;

            for (var i = 0; i <= endIndex; i++)
            {
                if (collection[i].CompareTo(collection[biggestElementIndex]) > 0)
                {
                    biggestElementIndex = i;
                }
            }

            Swap(collection, biggestElementIndex, endIndex);
            
            endIndex--;
            
            if (endIndex == 0)
                return;
        }
    }

    private static void Swap(List<T> collection, int i, int j)
    {
        (collection[i], collection[j]) = (collection[j], collection[i]);
    }
}

/*
 * for loop to i -1
 * save the biggest element
 * swap with latest element
 * for loop i - 1
 * ...
 */