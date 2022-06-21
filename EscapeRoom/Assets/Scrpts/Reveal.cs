using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reveal : MonoBehaviour
{
    public enum FlashLightType
    {
        DEFAULT
    }

    public FlashLightType flashLightType = FlashLightType.DEFAULT;
    private Light _light = null;

    [SerializeField]
    Material _material = null;

    void Start()
    {
        switch (flashLightType)
        {
            case FlashLightType.DEFAULT:
                _light = GameObject.Find("FlashLight").GetComponent<Light>();
                break;
        }
    }


    void Update()
    {
        if(_light!=null && _material!=null)
        {
            if(_light.enabled)
            {
                _material.SetVector("_LightPos", _light.transform.position);
                _material.SetVector("_LightDir", _light.transform.forward);
            }
            else
            {
                _material.SetVector("_LightPos", new Vector3(0, 0, 0));
                _material.SetVector("_LightDir", new Vector3(0, 0, 0));
            }
        }
    }
}
