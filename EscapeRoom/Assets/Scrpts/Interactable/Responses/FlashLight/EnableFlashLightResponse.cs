using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFlashLightResponse : Response
{
    [SerializeField]
    private FlashLightToggle toggle;
    public override void Respond()
    {
        toggle.isActive = true;
    }
}
