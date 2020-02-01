using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHandGrab : MonoBehaviour
{
    public Sprite Grabb;
    public Sprite Normal;
    public bool grabHold = false;
    private Collider2D coly=null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("c"))
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
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("test1");
        coly = other;
        if (coly.tag == "item" && grabHold == true)
        {
            print("test2");
            coly.transform.parent = this.gameObject.transform;
        }

    }
}
        
  
