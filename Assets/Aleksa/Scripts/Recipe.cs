using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "ScriptableObjects/recipe")]
public class Recipe : ScriptableObject
{
    public Part partToRepair;
    public string recipeTitle;
    public Step firstStep;
    public Step secondStep;
    public Step ThirdStep;

    public Step[] steps;
    public int currentStep;


}
