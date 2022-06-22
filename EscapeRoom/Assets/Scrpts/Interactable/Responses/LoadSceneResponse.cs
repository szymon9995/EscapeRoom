using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneResponse : Response
{
    [SerializeField]
    private string sceneName;
    public override void Respond()
    {
        if(sceneName != null)
            SceneManager.LoadScene(sceneName);
    }
}
