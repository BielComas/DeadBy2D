using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    Camera mainCamera;
    void Start()
    {
        if(target==null)
            target = transform;
        
        if(mainCamera==null)
            mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0 ;
        
        Vector3 LookAtDirection = mousePos - target.position;
        target.right = LookAtDirection;
    }
}
