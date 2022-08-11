using System;
using System.Collections.Generic;
using System.Linq;

public class Stack<T>
{
    private List<T> list;

    public Stack()
    {
        list = new List<T>();
    }

    public void Clear()
    {
        list.Clear();
    }

    public void Push(T item)
    {
        list.Add(item);
    }


    public void Pop()
    {
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            list.RemoveAt(Length() - 1);
        }
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return list[Length() - 1];
        }
    }

    public bool IsEmpty()
    {
        return (Length() == 0);
    }

    public int Length()
    {
        return list.Count();
    }

}

