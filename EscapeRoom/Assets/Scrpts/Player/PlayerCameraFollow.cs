using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour
{
    public Transform cameraPos;
    void Update()
    {
        //Makes camera always follow the player (orientation)
        cameraPos.position = transform.position;
    }
}
