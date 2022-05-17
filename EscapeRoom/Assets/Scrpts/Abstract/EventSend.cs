using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class EventSend : MonoBehaviour
{
    protected UnityEvent Send = new UnityEvent();
    [SerializeField]
    protected List<Response> responseObjects = new List<Response>();

    private void Start()
    {
        Send.AddListener(EventResponde);
        OnStart();
    }

    protected virtual void OnStart()
    {

    }

    public virtual void EventResponde()
    {
        foreach (Response response in responseObjects)
        {
            response.Respond();
        }
        Send.RemoveListener(EventResponde);
    }
}
