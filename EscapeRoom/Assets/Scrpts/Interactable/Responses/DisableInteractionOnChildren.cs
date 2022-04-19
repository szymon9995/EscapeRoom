using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInteractionOnChildren : Response
{
    public override void Respond()
    {
        foreach(Transform child in transform)
        {
            Interactable interactable = null;
            if(child.TryGetComponent<Interactable>(out interactable))
            {
                interactable.canInteract = false;
            }
        }
    }
}
