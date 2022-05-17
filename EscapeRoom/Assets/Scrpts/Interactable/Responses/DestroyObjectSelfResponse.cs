using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectSelfResponse : Response
{
    public override void Respond()
    {
        Destroy(transform.gameObject);
    }
}
