using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterIncResponse : Response
{
    [SerializeField]
    private OnCounterEquals count;
    public override void Respond()
    {
        count.counter.Inc();
    }
}
