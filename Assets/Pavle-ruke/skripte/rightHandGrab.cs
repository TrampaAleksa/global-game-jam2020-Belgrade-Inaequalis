using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHandGrab : MonoBehaviour
{
   

    public Sprite Grabb;
    public Sprite Normal;
    private HandGrab handGrab;
    
  

    void Awake()
    {
    }

    void Start()
    {
        handGrab = GetComponent<HandGrab>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Grabb;
            handGrab.TryGrabbing();

        }
        if (Input.GetKeyUp("space"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
            handGrab.ReleaseGrab();
        }
    }
     
    }

    
   

