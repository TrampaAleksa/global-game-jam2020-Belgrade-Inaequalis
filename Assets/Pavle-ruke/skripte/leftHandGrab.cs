using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHandGrab : MonoBehaviour
{
    public Sprite Grabb;
    public Sprite Normal;
    bool grabHold = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("c"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Grabb;
            grabHold = true;
            print(grabHold);

        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
            grabHold = false;

            print(grabHold);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        while(other.tag == "item" && grabHold==true)
        {
            other.transform.parent = this.gameObject.transform;
            if (grabHold == false)
            {
                other.transform.parent = null;
                break;
            }
        }
        {

        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "item" && this.gameObject.GetComponent<SpriteRenderer>().sprite != Grabb)
        {
            other.transform.parent = null;
        }
    }
}
