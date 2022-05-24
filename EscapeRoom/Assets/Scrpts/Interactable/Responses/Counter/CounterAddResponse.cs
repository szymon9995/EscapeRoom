using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAddResponse : Response
{
    [SerializeField]
    private OnCounterEquals count;
    [SerializeField]
    private int number;
    public override void Respond()
    {
        count.counter.Add(number);
    }
}
