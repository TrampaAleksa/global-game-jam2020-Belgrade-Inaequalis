using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHandGrab : MonoBehaviour
{
   

    public Sprite Grabb;
    public Sprite Normal;
    
  

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
            
            
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
            
        }       
        }
     
    }

    
   

