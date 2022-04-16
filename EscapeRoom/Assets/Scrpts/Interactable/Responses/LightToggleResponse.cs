using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggleResponse : Response
{
    public override void Respond()
    {
        Light light = GetComponent<Light>();
        light.enabled = !light.enabled;
    }
}
