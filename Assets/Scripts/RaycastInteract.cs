using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastInteract : MonoBehaviour
{
    private GameObject raycastedObject;

    public int rayLength;
    public LayerMask layerMaskInteract;

    public Image uiCrosshair;

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
        {
            CrosshairActive();
            if (hit.collider.CompareTag("Object"))
            {
                raycastedObject = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    raycastedObject.GetComponent<BenchBehaviour>().Open();
                   
                }
                        
            }
        }
        else
        {
            CrosshairNormal();
        }

    }
    void CrosshairActive()
    {
        uiCrosshair.color = Color.red;
    }
    void CrosshairNormal()
    {
        uiCrosshair.color = Color.white;
    }
}
