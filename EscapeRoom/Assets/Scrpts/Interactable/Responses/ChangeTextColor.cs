using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextColor : Response
{
    [SerializeField]
    private Color color = Color.red;

    private TextMesh textMesh = null;
    public override void Respond()
    {
        if(TryGetComponent<TextMesh>(out textMesh))
        {
            textMesh.color = color;
        }
        else
        {
            Debug.LogWarning("Object \"" + gameObject.name + " does not have TextMesh!");
        }
    }
}
