using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proba : MonoBehaviour
{
    bool triggerAlert=true;
    AudioManager audioManager;

    public bool OnStart()
    {
        audioManager.PlaySound("startOfDaySound");
        audioManager.PlaySound("backgroundSound");
        return false;        
    }
    private void Start() {
        audioManager= AudioManager.Instance;
        LoopsHandler.LoopDelegate onStartDelegate = OnStart;
        LoopsHandler.Instance.Loop(0.001f, OnStart);
    }   
    void Update()
    {
        if(Timer.Instance.TimerAlert()){
            if(triggerAlert){
                triggerAlert=false;
                audioManager.PlaySound("endOfDayBell");
            }
        }
    }
    
}
