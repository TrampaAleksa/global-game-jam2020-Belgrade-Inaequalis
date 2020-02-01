using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "ScriptableObjects")]
public class Recipe : ScriptableObject
{
    public Part partToRepair;
    public string recipeTitle;
    public Step firstStep;
    public Step secondStep;
    public Step ThirdStep;

}
