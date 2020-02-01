using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TryGrabbing();
    }


    public GameObject raycastObject;

    void TryGrabbing()
    {

        RaycastHit objectHit;

        Vector3 fwd = raycastObject.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(raycastObject.transform.position, fwd * 50, Color.green);
        if (Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 50, LayerMask.GetMask("Dropwdown")))
        {
            //do something if hit object ie
            if (objectHit.collider.gameObject.GetComponent<StepObject>() != null)
            {
                objectHit.collider.gameObject.transform.parent = gameObject.transform;
            }
        }
    }
}
