using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabb : MonoBehaviour
{
    public Sprite Grabb;
    public Sprite Normal;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Grabb;
        }else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
        }
        
    }
}
