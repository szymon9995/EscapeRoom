using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectible : MonoBehaviour, ICollectible
{
    public static event HandleItemCollected OnItemCollected;
    public delegate void HandleItemCollected(ItemData item);

    [SerializeField]
    private ItemData item;
    public void Collect()
    {
        OnItemCollected?.Invoke(item);
        Destroy(gameObject);
    }
}
