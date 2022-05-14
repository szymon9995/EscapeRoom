using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterCollisionOnButton : EventSend
{
    [SerializeField]
    private Rigidbody m_RigidBody = null;

    private void OnCollisionEnter(Collision collision)
    {
        if(m_RigidBody != null)
        {
            if(collision.rigidbody == m_RigidBody)
            {
                Send?.Invoke();
            }
        }
    }
}
