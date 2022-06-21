using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterDecResponse : Response
{
    [SerializeField]
    private OnCounterEquals count;
    public override void Respond()
    {
        count.counter.Dec();
    }
}
