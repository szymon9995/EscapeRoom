using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShowTextResponse : Response
{
    [SerializeField]
    private string message = "";

    private ShowTextHelper helper;

    private void Start()
    {
        helper = GameObject.Find("MessageReciver").transform.GetComponent<ShowTextHelper>();
    }

    public override void Respond()
    {
        if(helper != null)
            helper.DisplayText(message);
    }
}
