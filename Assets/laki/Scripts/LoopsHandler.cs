using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsHandler : MonoBehaviour 
{
    public static LoopsHandler Instance;

    public delegate bool LoopDelegate();

    private void Awake()
    {
        Instance = this;
    }

    public void Loop(float timeBetweenLoops, LoopDelegate loopable)
    {
        StartCoroutine(LoopEnum(timeBetweenLoops, loopable));
    }

    public IEnumerator LoopEnum(float timeBetweenLoops, LoopDelegate loopable) 
    {
            yield return new WaitForSeconds(timeBetweenLoops);
            if(loopable())
            yield return StartCoroutine(LoopEnum(timeBetweenLoops, loopable));

        yield break;
    }

 

}
