using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRecipesHandler : MonoBehaviour
{
    public static ActiveRecipesHandler Instance;

    void Awake()
    {
        Instance = this;
    }
   
    public Recipe[] activeRecipes;
    public Queue<Recipe> recepiesQueue;

    public void AddNewRecepiesToQueue(){

    }

    public void InteractionHappened(StepObject obj){
        for(int i =0; i< activeRecipes.Length; i++)
        {
            Recipe currentRecipe = activeRecipes[i];
            bool currentRecipeStepSuccessful = StepHandler.Instance.PlacedStepObject(obj, currentRecipe.steps[currentRecipe.currentStep - 1]);
            if (currentRecipeStepSuccessful) {
               currentRecipe.currentStep++;
               if(currentRecipe.currentStep == 4){
                   SwapWithNew(i, recepiesQueue.Dequeue());
               }
           }
        }
    }

    public Recipe SwapWithNew(int activeRecepiesIndex, Recipe newRecipe){
        activeRecipes[activeRecepiesIndex] = newRecipe;
        return newRecipe;
    }
}
