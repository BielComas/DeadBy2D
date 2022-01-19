using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    [SerializeField] GameObject flashlight;

    private void Start()
    {   
        flashlight.SetActive(false);    
    }
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            //so d'activar llanterna
            flashlight.SetActive(true);
        }
        if (Input.GetMouseButtonUp(1))
        {
            //so d'apagar llanterna
            flashlight.SetActive(false);
        }
    }
}
