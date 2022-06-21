using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInteactionAvibilityResponse : Response
{
    [SerializeField]
    private Interactable interactable;

    [SerializeField]
    private bool chnageTo = true;
    public override void Respond()
    {
        interactable.canInteract = chnageTo;
    }
}
