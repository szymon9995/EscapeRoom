using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSetResponse : Response
{
    [SerializeField]
    private OnCounterEquals count;
    [SerializeField]
    private int number;
    public override void Respond()
    {
        count.counter.Set(number);
    }
}