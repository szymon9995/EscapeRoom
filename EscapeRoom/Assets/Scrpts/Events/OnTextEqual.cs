using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTextEqual : EventSend
{
    [SerializeField]
    private TextMesh m_TextMesh = null;

    [SerializeField]
    private string text = "";

    private void Update()
    {
        if (m_TextMesh != null)
        {
            if (m_TextMesh.text == text)
            {
                Send?.Invoke();
            }
        }
    }
}
