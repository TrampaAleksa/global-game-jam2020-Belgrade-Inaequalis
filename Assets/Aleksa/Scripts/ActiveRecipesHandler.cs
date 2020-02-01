using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRecipesHandler : MonoBehaviour
{
    public static ActiveRecipesHandler Instance;
    private int currentQueueIndex = 0;

    void Awake()
    {
        Instance = this;
          activeRecipesClones = new Recipe[activeRecipes.Length];
          for(int i=0; i<activeRecipes.Length; i++){
              activeRecipesClones[i] = CloneRecipe(activeRecipes[i]);
            print("cloned " + i);
        }
    }
   
    public Recipe[] activeRecipes;
    public Recipe[] activeRecipesClones;
    public Recipe[] recepiesQueue;

    public void AddNewRecepiesToQueue(){

    }

    public void InteractionHappened(StepObject obj){
        for(int i =0; i< activeRecipes.Length; i++)
        {
            Recipe currentRecipe = activeRecipesClones[i];
            print(currentRecipe.steps[currentRecipe.currentStep-1].currentStepObjectIndex);
            bool currentRecipeStepSuccessful = StepHandler.Instance.PlacedStepObject(obj, currentRecipe.steps[currentRecipe.currentStep - 1]);
            if (currentRecipe.steps[currentRecipe.currentStep-1].isFinished) {
                print("swapping");
                   SwapWithNew(i, recepiesQueue[currentQueueIndex]);
                   currentQueueIndex++;
           }
            if (currentRecipeStepSuccessful) currentRecipe.currentStep++;
        }
    }

    public Recipe SwapWithNew(int activeRecepiesIndex, Recipe newRecipe){
        print("swapped " + activeRecipesClones[activeRecepiesIndex].name + " with : " + CloneRecipe(newRecipe).name);
        activeRecipesClones[activeRecepiesIndex] = CloneRecipe(newRecipe);
        return activeRecipesClones[activeRecepiesIndex];             
    }

    public Recipe CloneRecipe(Recipe recipeToClone){
        Recipe newRecipe = Instantiate(recipeToClone);
        for(int i=0; i<activeRecipes.Length; i++){
        newRecipe.steps[i] = Instantiate(newRecipe.steps[i]);
        }
        return newRecipe;
    }
}
