using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHandGrab : MonoBehaviour
{
    
    public Sprite Grabb;
    public Sprite Normal;
    private HandGrab handGrab;

    void Awake()
    {
        //leftHand.GetComponent<leftHandGrab>().grabHold
    }

    void Start()
    {
        handGrab = GetComponent<HandGrab>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Grabb;
            handGrab.TryGrabbing();

        }
        if (Input.GetKeyUp("c"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
            handGrab.ReleaseGrab();

        }



    }

    


}


