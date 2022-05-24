using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLightOn : EventSendCountinous
{
    private bool lightLastState;

    [SerializeField]
    private Light _light;


    protected override void OnStart()
    {
        if (_light != null)
        {
            lightLastState = _light.enabled;
        }
        else
        {
            Debug.LogWarning("The light for " + transform.name + " has not been set!");
        }
    }

    private void Update()
    {
        if (lightLastState != _light.enabled)
        {
            lightLastState = _light.enabled;
            if (lightLastState == true)
            {
                Send?.Invoke();
            }
        }
    }
}
