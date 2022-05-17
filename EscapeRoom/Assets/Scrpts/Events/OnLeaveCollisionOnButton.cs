using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLeaveCollisionOnButton : EventSendCountinous
{
    [SerializeField]
    private Rigidbody m_RigidBody = null;

    private void OnCollisionExit(Collision collision)
    {
        if (m_RigidBody != null)
        {
            if (collision.rigidbody == m_RigidBody)
            {
                Send?.Invoke();
            }
        }
    }
}
