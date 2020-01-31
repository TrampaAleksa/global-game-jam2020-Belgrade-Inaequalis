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
        if(Input.GetKey("h")){
            audioManager.PlaySound("hammer");
            
        }
        if(Input.GetKey("j")){
            
            audioManager.StopSound("hammer");
            
        }
        if(Input.GetKey("k")){
            
            audioManager.LoopSound("hammer",true);
        }
    }
}
