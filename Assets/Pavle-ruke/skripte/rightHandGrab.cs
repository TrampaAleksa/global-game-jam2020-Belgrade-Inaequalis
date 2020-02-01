using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHandGrab : MonoBehaviour
{
    bool par = false;

    public Sprite Grabb;
    public Sprite Normal;
    bool grabHold=false;
    private Collider2D coly=null;

    void Awake()
    {
        //leftHand.GetComponent<leftHandGrab>().grabHold
    }

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
            coly = null;
        }
        if (par==true)
        {
            if (grabHold==true)
            {
                coly.transform.parent = this.gameObject.transform;
            }
            else if (grabHold==false)
            {

            }
            
        }
     
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "item")
        {
            coly = other;
            par = true;
        }
        print("ON TRIGER ENTER");
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        par = false;
        print("ON TRIGGER EXIT");
    }

   
}
