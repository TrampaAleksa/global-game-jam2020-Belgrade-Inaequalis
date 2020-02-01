using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRecipesHandler : MonoBehaviour
{
    public static ActiveRecipesHandler Instance;

    public Recipe[] activeRecipes;
    public Recipe[] activeRecipesClones;
    public Recipe[] recipesForQueueing;

    private Queue<Recipe> recipesQueue;
    void Awake()
    {
          Instance = this;

          activeRecipesClones = new Recipe[activeRecipes.Length];
          for(int i=0; i<activeRecipes.Length; i++){
              activeRecipesClones[i] = CloneRecipe(activeRecipes[i]);
          }
        recipesQueue = new Queue<Recipe>();
        RandomizeArray.Randomize<Recipe>(recipesForQueueing);
        AddNewRecepiesToQueue();
    }

    public void AddNewRecepiesToQueue(){
        RandomizeArray.Randomize<Recipe>(recipesForQueueing);
        foreach (var recipe in recipesForQueueing)
        {
            recipesQueue.Enqueue(recipe);
        }
    }

    public void InteractionHappened(StepObject obj){
        for(int i = 0; i< activeRecipes.Length; i++)
        {
            Recipe currentRecipe = activeRecipesClones[i];
            Step currentRecipeStep = currentRecipe.steps[currentRecipe.currentStep - 1];

            bool currentRecipeStepSuccessful =
                StepHandler.Instance.PlacedStepObjectSuccesfully
                (obj, currentRecipeStep);

            if (currentRecipe.isFinished) {
                print("swapping");
                   SwapWithNew(i);
            }
            if (currentRecipeStepSuccessful) currentRecipe.currentStep++;
        }
    }

    public Recipe SwapWithNew(int activeRecepiesIndex){
        if(recipesQueue.Count < 2)
        {
            AddNewRecepiesToQueue();
        }
        activeRecipesClones[activeRecepiesIndex] = CloneRecipe(recipesQueue.Dequeue());
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
