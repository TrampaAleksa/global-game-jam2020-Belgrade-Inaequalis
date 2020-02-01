using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRecipe : MonoBehaviour
{
    public Recipe testRecipe;
    // Start is called before the first frame update
    void Start()
    {
        StepObject obj = GameObject.Find("Screwdriver").GetComponent<StepObject>();
        StepObject obj2 = GameObject.Find("Wire").GetComponent<StepObject>();
        StepObject obj3 = GameObject.Find("Hairdrier").GetComponent<StepObject>();


        StepHandler.Instance.PlacedStepObjectSuccesfully(obj, testRecipe.firstStep);
        StepHandler.Instance.PlacedStepObjectSuccesfully(obj2, testRecipe.firstStep);
        StepHandler.Instance.PlacedStepObjectSuccesfully(obj3, testRecipe.firstStep);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
