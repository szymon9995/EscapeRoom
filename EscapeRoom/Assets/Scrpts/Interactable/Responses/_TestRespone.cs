using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _TestRespone : Response
{
    public override void Respond()
    {
        Debug.Log("The " + transform.name + " responded!");
    }
}
