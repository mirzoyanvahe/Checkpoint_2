using System;

public class CustomList<T>
{
    private T[] _items;
    private int _count;

    public CustomList(int initialCapacity = 4)
    {
        if (initialCapacity < 0) throw new ArgumentOutOfRangeException(nameof(initialCapacity));
        _items = new T[initialCapacity];
        _count = 0;
    }

    public int Count => _count;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException(nameof(index));
            return _items[index];
        }
    }

    public void Add(T item)
    {
        if (_count == _items.Length)
        {
            Resize(_items.Length * 2);
        }
        _items[_count++] = item;
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(_items, item, 0, _count);
        if (index >= 0)
        {
            _count--;
            Array.Copy(_items, index + 1, _items, index, _count - index);
            _items[_count] = default;
            return true;
        }
        return false;
    }

    private void Resize(int newSize)
    {
        T[] newArray = new T[newSize];
        Array.Copy(_items, 0, newArray, 0, _count);
        _items = newArray;
    }
}
