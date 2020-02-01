using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proba : MonoBehaviour
{
    AudioManager audioManager;
    void Start()
    {
        audioManager=AudioManager.Instance;
    }
    
    void Update()
    {
        if(Input.GetKeyDown("k"))
            audioManager.PlaySound("hammer");
    }
}
