using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextHelper : MonoBehaviour
{
    [SerializeField]
    private Text UIText;
    public void DisplayText(string text)
    {
        UIText.enabled = true;
        UIText.text = text;
        StartCoroutine("DisplayTextTime");
    }

    IEnumerator DisplayTextTime()
    {
        yield return new WaitForSeconds(6.0f);
        UIText.text = "";
        UIText.enabled = false;
    }
}
