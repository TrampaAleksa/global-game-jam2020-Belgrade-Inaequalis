using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeTemplateHandler : MonoBehaviour
{

    public RecipeTemplate[] recipeTemplatesInCanvas;
    public static RecipeTemplateHandler Instance;

    public CheckFirstStep[] stepAnimators;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        
    }

    public void PutRecipeInTemplate(Recipe recipeToPut, int indexInCanvas)
    {
        RecipeTemplate selectedRecipeTemplate = recipeTemplatesInCanvas[indexInCanvas];
        selectedRecipeTemplate.title.image.sprite = recipeToPut.partToRepair.brokenImage;
        selectedRecipeTemplate.title.text.sprite = recipeToPut.partToRepair.titleImage;

        int i = 0;
        foreach (var step in recipeToPut.steps)
        {
            foreach (var stepObject in step.stepObjects)
            {
                print(stepObject.GetDefaultImage().name);
                selectedRecipeTemplate.stepImages[i].sprite = stepObject.GetDefaultImage();
                i++;
            }
        }

    }

    public void RefreshTemplates(Recipe[] activeRecipes)
    {
        for (int i = 0; i < activeRecipes.Length; i++)
        {
            PutRecipeInTemplate(activeRecipes[i], i);
        }
    }
}
