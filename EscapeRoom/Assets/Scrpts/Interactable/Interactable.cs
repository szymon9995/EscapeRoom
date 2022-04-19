using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Interactable : MonoBehaviour
{
    public virtual float radius { get; } = 3.0f;
    public virtual Color color => Color.yellow;

    [SerializeField]
    protected List<Response> responseObjects = new List<Response>();

    public bool canInteract = true;

    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public virtual void OnInteract()
    {
        foreach (Response response in responseObjects)
        {
            response.Respond();
        }
    }
    public abstract void OnStartHover();
    public abstract void OnEndHover();
}

