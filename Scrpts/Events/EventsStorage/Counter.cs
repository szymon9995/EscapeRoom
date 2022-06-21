using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter
{
    public int Count { private set; get; } = 0;
    public void Inc()
    {
        Count++;
    }

    public void Dec()
    {
        Count--;
    }

    public void Set(int number)
    {
        Count = number;
    }

    public void Add(int number)
    {
        Count += number;
    }

    public void Sub(int number)
    {
        Count -= number;
    }
}
