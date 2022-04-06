using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCubeClick : Interactable
{
    //REMEBER if possible change so that the type is that interface
    [SerializeField]
    private GameObject responseObject = null;
    public override void OnEndHover()
    {

    }

    public override void OnInteract()
    {
        if(responseObject.GetComponent<IResponse>() != null)
        {
            responseObject.GetComponent<IResponse>().Response();
        }
    }

    public override void OnStartHover()
    {

    }
}
