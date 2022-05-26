using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem
{
    public ItemData item_data { get; private set; }
    public int stackAmount { get; private set; } = 0;
    public int maxStact { get; private set; } = 1;

    public InventoryItem(ItemData item)
    {
        item_data = item;
    }

    public void AddToStack()
    {
        stackAmount++;
    }

    public void RemoveFromStack()
    {
        stackAmount--;
    }
}
