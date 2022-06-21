using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSendCountinous : EventSend
{
    public override void EventResponde()
    {
        foreach (Response response in responseObjects)
        {
            response.Respond();
        }
    }
}
