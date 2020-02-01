using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestActiveRecipeHandler : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        ActiveRecipesHandler.Instance.InteractionHappened(FindObject("Screwdriver"));
        ActiveRecipesHandler.Instance.InteractionHappened(FindObject("Wire"));
        ActiveRecipesHandler.Instance.InteractionHappened(FindObject("Hairdrier"));
    }

    public StepObject FindObject(string name){
        return GameObject.Find(name).GetComponent<StepObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
