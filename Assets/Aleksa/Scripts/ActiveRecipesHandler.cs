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
    private void Start()
    {
        RecipeTemplateHandler.Instance.RefreshTemplates(activeRecipesClones);
        Spawner.Instance.SpawnNewItem(activeRecipesClones[0].partToRepair.gameObject, 0 );
        Spawner.Instance.SpawnNewItem(activeRecipesClones[1].partToRepair.gameObject, 1);
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

            print("currentRecipeStep" + currentRecipe.currentStep);
            bool currentRecipeStepSuccessful =
                StepHandler.Instance.PlacedStepObjectSuccesfully
                (obj, currentRecipeStep);

            if (currentRecipeStepSuccessful) {
                print("did it");
                RecipeTemplateHandler.Instance.stepAnimators[i].SetStepIsFinished(true, currentRecipe.currentStep - 1);
            currentRecipe.currentStep++;
            }
            if (currentRecipe.currentStep > currentRecipe.steps.Length)
                currentRecipe.isFinished = true;

            if (currentRecipe.isFinished) {
                print("swapping");
                   SwapWithNew(i, obj.gameObject);
            }
        }
    }

    public Recipe SwapWithNew(int activeRecepiesIndex, GameObject objectToSwapWith){
        if(recipesQueue.Count < 2)
        {
            AddNewRecepiesToQueue();
        }
        activeRecipesClones[activeRecepiesIndex] = CloneRecipe(recipesQueue.Dequeue());
        RecipeTemplateHandler.Instance.PutRecipeInTemplate
            (activeRecipesClones[activeRecepiesIndex], activeRecepiesIndex);
        Destroy(objectToSwapWith);
        Spawner.Instance.SpawnNewItem(activeRecipesClones[activeRecepiesIndex].partToRepair.gameObject, activeRecepiesIndex);
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
