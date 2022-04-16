using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAddTo : Response
{
    [SerializeField]
    private string AddedText = "";

    [SerializeField]
    private TextMesh text = null;

    [SerializeField]
    private bool canAdd = true;

    [SerializeField]
    private int maxTextSize = -1; //-1 is infinite

    public override void Respond()
    {
        if (text != null && canAdd)
        {
            if(maxTextSize != -1 && text.text.Length >= maxTextSize)
            {
                return;
            }
            text.text += AddedText;
        }
    }
}
