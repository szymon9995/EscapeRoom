using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEnabledObjectResponse : Response
{
    [SerializeField]
    private bool enableState = true;
    [SerializeField]
    GameObject obj;
    public override void Respond()
    {
        obj.SetActive(enableState);
    }
}
