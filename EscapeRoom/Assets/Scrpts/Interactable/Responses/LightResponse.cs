using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightResponse : MonoBehaviour, IResponse
{
    public void Response()
    {
        Light light = GetComponent<Light>();
        light.enabled = !light.enabled;
    }
}
