using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightToggle : MonoBehaviour
{
    private Inventory invetory;

    private KeyCode key = KeyCode.F;

    [SerializeField]
    private Light _light;
    [SerializeField]
    private ItemData flashLight;

    private void Start()
    {
        invetory = GameObject.Find("Inventory").GetComponent<Inventory>();
        if(invetory == null)
        {
            Debug.LogWarning("Could not find inventory");
        }
    }
    private void Update()
    {
        if(invetory != null)
        {
            if (Input.GetKeyDown(key) && invetory.IsItem("FlashLight"))
            {
                _light.enabled = !_light.enabled;
            }
        }
    }
}
