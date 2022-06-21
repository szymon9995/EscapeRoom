using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    private float rotationX;
    private float rotationY;

    [SerializeField]
    private Texture2D cursorTexture;
    void Start()
    {
        //Lock cursor to center of the screen for First Person View.
        //Aka so that mouse won't go out of window.

        //REMEMBER Make curson have an incon later

        Cursor.lockState = CursorLockMode.Locked;
        if (cursorTexture != null)
            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }

    void Update()
    {
        //Get Mouse Input 
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX *Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY * Time.deltaTime;

        rotationY += mouseX;
        rotationX -= mouseY;

        //Make sure Up and Down rotation won't go in circle...creepy.
        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f);

        //Apply rotation
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        orientation.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}
