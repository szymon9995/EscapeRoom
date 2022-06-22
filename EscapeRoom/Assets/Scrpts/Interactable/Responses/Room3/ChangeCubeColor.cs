using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : Response
{
    public Color m_color;
    private List<Color> colors = new List<Color>();
    private int pos = 0;
    private void Start()
    {
        colors.Add(Color.white);
        colors.Add(Color.red);
        colors.Add(Color.yellow);
        colors.Add(Color.blue);
        colors.Add(Color.green);
        colors.Add(Color.black);
        colors.Add(Color.magenta);

        m_color = colors[0];
    }
    public override void Respond()
    {
        pos++;
        if(pos>=colors.Count)
            pos=0;
        m_color = colors[pos];
        GetComponent<Renderer>().material.color = m_color;
    }
}
