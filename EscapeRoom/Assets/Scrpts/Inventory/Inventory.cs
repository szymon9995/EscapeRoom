using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> inventory = new List<InventoryItem>();
    private Dictionary<ItemData, InventoryItem> m_InventoryItems = new Dictionary<ItemData, InventoryItem>();

    private void OnEnable()
    {
        Collectible.OnItemCollected += Add;
    }

    private void OnDisable()
    {
        Collectible.OnItemCollected -= Add;
    }


    public void Add(ItemData itemData)
    {
        if(m_InventoryItems.TryGetValue(itemData, out InventoryItem item))
        {
            item.AddToStack();
            Debug.Log($"Stack of {itemData.name} is now {item.stackAmount}");
        }
        else
        {
            InventoryItem newItem = new InventoryItem(itemData);
            m_InventoryItems.Add(itemData, newItem);
            inventory.Add(newItem);
            Debug.Log($"Added {itemData.name} to inventory");
        }
    }

    public void Remove(ItemData itemData)
    {
        if (m_InventoryItems.TryGetValue(itemData, out InventoryItem item))
        {
            item.RemoveFromStack();
            if(item.stackAmount<=0)
            {
                m_InventoryItems.Remove(itemData);
                inventory.Remove(item);
            }
        }
    }

    public bool IsItem(string name)
    {
        if (inventory.Where(item => item.item_data.item_name == name) != null)
            return true;
        return false;
    }

    public bool IsItemStack(string name, int stackAmount)
    {
        if (inventory.Where(item => item.item_data.item_name == name && item.stackAmount == stackAmount) != null)
        {
            return true;
        }
        return false;
    }
}
