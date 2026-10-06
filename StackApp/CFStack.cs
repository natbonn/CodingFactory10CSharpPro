using System;
using System.Collections.Generic;
using System.Text;

namespace StackApp;

internal class CFStack
{
    private const int DefaultCapacity = 100;
    private readonly int[] _items;
    private int _top = -1;

    public CFStack() : this(DefaultCapacity) { }
    
    public CFStack(int capacity) 
    {
        if (capacity <= 0)
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be grater than zero.");
        _items = new int[capacity];
    }

    // Expression-bodied member for getter (only) - public properties
    public int Count => _top + 1;
    public int Capacity => _items.Length;   // when stack is full
    public bool IsEmpty => _top == -1;      // IsEmpty (state)
    public bool IsFull => _top == _items.Length - 1;

    //
    public void Push(int item)
    {
        if (IsFull)
            throw new StackIsFullException();
        _items[++_top] = item;
    }

    public int Pop()
    {
        if (IsEmpty)
            throw new StackIsEmptyException();
        return _items[_top--];
    }

    public int Peek(int index)
    {
        if (index < 0 || index > _top)
            throw new ArgumentOutOfRangeException("Index is out of bounds.");
        return _items[index];
    }
}
