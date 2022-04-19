using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField]
    private float radius = 10.0f;

    [SerializeField]
    private Camera playerCamera;

    private Interactable curTarget = null;

    private KeyCode interactionKey = KeyCode.E;

    private void Update()
    {
        RaycastInteract();

        if (Input.GetKeyDown(interactionKey))
        {
            if (curTarget != null)
            {
                curTarget.OnInteract();
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(playerCamera.transform.position, radius);
    }

    void RaycastInteract()
    {
        RaycastHit hit;

        Ray cameraRay = playerCamera.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(cameraRay,out hit,radius))
        {
            Interactable target = hit.collider.GetComponent<Interactable>();
            if(target!=null)
            {
                if(hit.distance <= target.radius && target.canInteract)
                {
                    if (target == curTarget)
                    {
                        return;
                    }
                    else if (curTarget != null)
                    {
                        curTarget.OnEndHover();
                        curTarget = target;
                        curTarget.OnStartHover();
                        return;
                    }
                    else
                    {
                        curTarget = target;
                        curTarget.OnStartHover();
                        return;
                    }
                }
            }
        }

        if (curTarget != null)
        {
            curTarget.OnEndHover();
            curTarget = null;
            return;
        }
    }
}
