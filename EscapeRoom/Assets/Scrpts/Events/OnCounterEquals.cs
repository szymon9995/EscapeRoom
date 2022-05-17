using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCounterEquals : EventSend
{
    public Counter counter = new Counter();

    [SerializeField]
    private int count_equals;
    [SerializeField]
    private int count_begin_number;

    private void Start()
    {
        counter.Set(count_begin_number);
    }
    private void Update()
    {
        if(counter.Count == count_equals)
        {
            Send?.Invoke();
        }
    }
}
