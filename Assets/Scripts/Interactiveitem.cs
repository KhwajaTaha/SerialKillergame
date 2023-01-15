using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactiveitem : MonoBehaviour
{
    public float interactdistance = 5f;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, interactdistance))
            {
                if(hit.collider.CompareTag("door"))
                {
                    hit.collider.transform.GetComponent<doorscript>().Changedoorstate();
                }
            }
        }
    }
}
