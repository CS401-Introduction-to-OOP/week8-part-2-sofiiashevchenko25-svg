namespace ConsoleApp5;

using System.Collections.Generic;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public long GetTotalSize()
    {
        long all = new();
        foreach (T items in _items)
        {
            all += items.GetSize();
        }

        return all;
    }

    
}