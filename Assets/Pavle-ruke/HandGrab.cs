using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrab : MonoBehaviour
{
    public GameObject itemsHolder;
    private Vector3 positionWhenPickedUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    public GameObject raycastObject;
    ContactFilter2D contactFilter;


    public void TryGrabbing()
    {
        // objectHit.collider.gameObject.GetComponent<StepObject>() != null
        Vector3 fwd = raycastObject.transform.TransformDirection(Vector3.forward);
        RaycastHit2D objectHit= Physics2D.Raycast(transform.position, fwd, 40, LayerMask.GetMask("Item"));
        

        Debug.DrawRay(raycastObject.transform.position, fwd * 20, Color.green);
        if (objectHit.collider!=null)
        {
            GameObject objectPickedUp = objectHit.collider.gameObject;
            positionWhenPickedUp = objectPickedUp.transform.position;
            objectPickedUp.transform.parent = gameObject.transform;
        }
    }

    public void ReleaseGrab()
    {
        // objectHit.collider.gameObject.GetComponent<StepObject>() != null
        Vector3 fwd = raycastObject.transform.TransformDirection(Vector3.forward);
        RaycastHit2D objectHit = Physics2D.Raycast(transform.position, fwd, 40, LayerMask.GetMask("Dropdown"));

        Debug.DrawRay(raycastObject.transform.position, fwd * 20, Color.green);
        if (objectHit.collider != null)
        {
            print("Succesfully dropped down");
            // Ovde ide kod za rad sa receptima (ActiveRecipesHandler.Instance)
        }
        else
        {
            print("Unsuccesfully dropped down");
        }
        if(gameObject.GetComponentInChildren<StepObject>() != null)
        {
            ResetItem(gameObject.GetComponentInChildren<StepObject>().gameObject);
        }

    }

    private void ResetItem(GameObject itemToReset)
    {
        itemToReset.transform.parent = itemsHolder.transform;
        itemToReset.transform.position = positionWhenPickedUp;
    }
}
