using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFirstStep : MonoBehaviour
{
    public Animator[] animators;
 
    private string[] parameterNames = {
        "firstStepIsFinished",
        "secondStepIsFinished",
        "thirdStepIsFinished"
    };
    // Update is called once per frame
    void Update()
    {
        SetStepIsFinished(true,0);
        SetStepIsFinished(true,1);
        SetStepIsFinished(true,2);
    }

    public void SetStepIsFinished(bool isFinished, int stepIndex) // Prosledi trampin isFinished flag
    {
        animators[stepIndex].SetBool(parameterNames[stepIndex], isFinished);
    }

}
