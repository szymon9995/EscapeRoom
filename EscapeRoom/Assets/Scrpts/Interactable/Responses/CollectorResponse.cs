using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorResponse : Response
{
    public override void Respond()
    {
        ICollectible collectible = transform.GetComponent<ICollectible>();
        if(collectible != null)
        {
            collectible.Collect();
        }
    }
}
