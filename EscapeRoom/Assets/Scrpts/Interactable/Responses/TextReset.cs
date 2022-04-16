using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextReset : Response
{
    [SerializeField]
    private TextMesh text = null;

    [SerializeField]
    private bool canReset = true;
    public override void Respond()
    {
        if(text != null && canReset)
        {
            text.text = "";
        }
    }
}
