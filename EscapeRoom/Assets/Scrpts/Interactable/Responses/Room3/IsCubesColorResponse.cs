using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCubesColorResponse : Response
{
    [SerializeField]
    ChangeCubeColor cube1;

    [SerializeField]
    ChangeCubeColor cube2;

    [SerializeField]
    Response response;

    [SerializeField]
    Interactable interactable;
    public override void Respond()
    {
        if(cube1.m_color == Color.magenta && cube2.m_color == Color.blue)
        {
            response.Respond();
            interactable.canInteract = false;
        }
    }
}
