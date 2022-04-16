using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public float radius { get; } = 3.0f;
    public Color color = Color.yellow;

    //REMEBER if possible change so that the type is that interface
    [SerializeField]
    private List<Response> responseObjects = new List<Response>();

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
