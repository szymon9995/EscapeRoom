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

    public bool isActive = false;
    private void Update()
    {
            if (Input.GetKeyDown(key) && isActive)
            {
                _light.enabled = !_light.enabled;
            }
    }
}
