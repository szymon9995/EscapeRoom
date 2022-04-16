using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSelfResponse : Interactable
{

    public override Color color => Color.red;

    protected override List<Response> responseObjects => null;

    public override void OnEndHover()
    {

    }

    public override void OnInteract()
    {
        Response response = null;
        if(TryGetComponent<Response>(out response))
        {
            response.Respond();        
        }
    }

    public override void OnStartHover()
    {

    }
}
