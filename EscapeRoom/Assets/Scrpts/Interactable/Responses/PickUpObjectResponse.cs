using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjectResponse : Response
{
    private bool isHeld = false;

    private Transform holder = null;

    private Rigidbody rb = null;

    private void Start()
    {
        holder = GameObject.Find("PlayerPickUp").transform;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(isHeld)
        {
            MoveObject();
        }
    }
    public override void Respond()
    {
        if (holder)
        {
            if (!isHeld && rb != null)
            {
                PickUp();
            }
            else
            {
                DropDown();
            }
        }
        else
        {
            Debug.LogWarning("Could Not Find Player Pick Up!!!");
        }
    }

    private void PickUp()
    {
        rb.useGravity = false;
        rb.transform.position = holder.position;

        isHeld = true;
    }

    private void DropDown()
    {
        rb.useGravity = true;

        isHeld = false;
    }

    private void MoveObject()
    {
        if (Vector3.Distance(this.transform.position, holder.position) > 0.01f)
        {
            this.transform.position = holder.position;
        }
    }
}
