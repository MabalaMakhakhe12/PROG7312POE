using System;
using System.Collections.Generic;

public class PriorityQueue<TElement, TPriority> where TPriority : IComparable
{
    private List<(TElement Element, TPriority Priority)> elements = new List<(TElement, TPriority)>();

    public int Count => elements.Count;

    public void Enqueue(TElement element, TPriority priority)
    {
        elements.Add((element, priority));
        elements.Sort((x, y) => y.Priority.CompareTo(x.Priority));  // Sort by priority in descending order
    }

    public TElement Dequeue()
    {
        var element = elements[0].Element;
        elements.RemoveAt(0);
        return element;
    }

    public IEnumerable<(TElement Element, TPriority Priority)> UnorderedItems => elements;
}
