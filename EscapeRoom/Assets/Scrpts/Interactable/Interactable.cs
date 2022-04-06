using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public float radius { get; } = 3.0f;
    public Color color = Color.yellow;

    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public abstract void OnInteract();
    public abstract void OnStartHover();
    public abstract void OnEndHover();
}
