﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbinAnObject : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "item")
        {
            print("pipnuo item");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
