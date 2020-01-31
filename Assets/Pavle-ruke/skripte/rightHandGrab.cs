using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHandGrab : MonoBehaviour
{
    public Sprite Grabb;
    public Sprite Normal;
    bool grabHold=false;
    Collider2D coly=null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Grabb;
            grabHold = true;
            
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
            grabHold = false;
        }

        if (grabHold == false)
        {
            coly.transform.parent = null;  //baca gresku, Object reference is not an instane of an object
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        coly = other;
        if (coly.tag == "item" && grabHold==true)
        {
            coly.transform.parent = this.gameObject.transform;
        }
    }

   
}
