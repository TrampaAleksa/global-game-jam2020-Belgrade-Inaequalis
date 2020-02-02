using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Step", menuName = "ScriptableObjects/step")]
public class Step : ScriptableObject
{
    public StepObject[] stepObjects;
    [SerializeField]
    public int currentStepObjectIndex = 1;
    public bool isFinished = false;
   
}
